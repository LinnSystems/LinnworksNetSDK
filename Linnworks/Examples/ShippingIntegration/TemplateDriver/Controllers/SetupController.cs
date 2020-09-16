using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplateDriver.Controllers
{
    public class SetupController : System.Web.Http.ApiController
    {
        [HttpPost()]
        [ActionName("AddNewUser")]
        public Models.AddNewUserResponse AddNewUser(Models.AddNewUserRequest request)
        {
            try
            {
                Classes.AuthorizationConfig newConfig = Classes.AuthorizationConfig.CreateNew(request.Email, request.LinnworksUniqueIdentifier, request.AccountName);
                return new Models.AddNewUserResponse()
                {
                    AuthorizationToken = newConfig.AuthorizationToken.ToString()
                };
            }
            catch (Exception ex) {
                return new Models.AddNewUserResponse("AddNewUser error : " + ex.Message);
            }
        }

        [HttpPost()]
        [ActionName("UserConfig")]
        public Models.UserConfigResponse UserConfig(Models.UserConfigRequest request)
        {
            // authenticate the user first
            Classes.AuthorizationConfig auth = Classes.AuthorizationConfig.Load(request.AuthorizationToken);
            if (auth == null)
            {
                return new Models.UserConfigResponse()
                {
                    IsError = true,
                    ErrorMessage = "Authorization failed for token " + request.AuthorizationToken
                };
            }

            // if config is not activated, i.e. in Wizard Stage - the user is going through the integration steps
            if (!auth.IsConfigActive)
            {
                if (auth.ConfigStatus == "")    // if new integration, lets assign a config stage to the integration process, in this case we will ask for Customer Details
                {
                    auth.ConfigStatus = "ContactStage";
                    auth.Save();
                }

                if (auth.ConfigStatus == "ContactStage")    // if config stage is ContactStage return the appropriate stage
                {
                    return new Models.UserConfigResponse()
                    {
                        ConfigStage = ConfigStageClasses.ContactStage.GetContactStage,
                        ConfigStatus = "ContactStage"
                    };
                }

                if (auth.ConfigStatus == "ValuesStage")
                {
                    return new Models.UserConfigResponse()
                    {
                        ConfigStage = ConfigStageClasses.ValuesStage.GetValuesStage,
                        ConfigStatus = "ValuesStage"
                    };
                }
                if (auth.ConfigStatus == "DescriptionStage") 
                {
                    return new Models.UserConfigResponse()
                    {
                        ConfigStage = ConfigStageClasses.DescriptionStage.GetDescriptionStage,
                        ConfigStatus = "DescriptionStage"
                    };
                }

                // finally if we don't have a specific handler for the stage name, throw an error
                return new Models.UserConfigResponse("Config stage is not handled: " + auth.ConfigStatus);
            }
            else   // if the integration config is in comlpeted stage (i.e. this is an active config)
            {
                return new Models.UserConfigResponse()
                {
                    ConfigStage = ConfigStageClasses.UserConfigStage.GetUserConfigStage(auth),
                    IsConfigActive = true,      // MUST SET THIS TO TRUE for the config to actuall be treated as completed               
                    ConfigStatus = "CONFIG"
                };
            }            
        }

        [HttpPost()]
        [ActionName("UpdateConfig")]
        public Models.UpdateConfigResponse UpdateConfig(Models.UpdateConfigRequest request)
        {
            try
            {
                // first authenticate the user and load it's config file

                Classes.AuthorizationConfig auth = Classes.AuthorizationConfig.Load(request.AuthorizationToken);
                if (auth == null)
                {
                    return new Models.UpdateConfigResponse("Authorization failed for token " + request.AuthorizationToken);
                }


                // lets make sure the configstage known by linnworks is the same as what we have locally. This is important to avoid discrepency in the steps
                if (auth.ConfigStatus != request.ConfigStatus)
                {
                    return new Models.UpdateConfigResponse("Current config stage is not what is sent in the Update");
                }


                // when current stage is ContactStage lets save details specific by the user into the configuration file locally
                if (auth.ConfigStatus == "ContactStage")
                {
                    auth.AccountName = request.ConfigItems.Find(s => s.ConfigItemId == "NAME").SelectedValue;
                    auth.AddressLine1 = request.ConfigItems.Find(s => s.ConfigItemId == "ADDRESS1").SelectedValue;
                    auth.AddressLine2 = request.ConfigItems.Find(s => s.ConfigItemId == "ADDRESS2").SelectedValue;
                    auth.AddressLine3 = request.ConfigItems.Find(s => s.ConfigItemId == "ADDRESS3").SelectedValue;
                    auth.City = request.ConfigItems.Find(s => s.ConfigItemId == "CITY").SelectedValue;
                    auth.County = request.ConfigItems.Find(s => s.ConfigItemId == "REGION").SelectedValue;
                    auth.CountryCode = request.ConfigItems.Find(s => s.ConfigItemId == "COUNTRY").SelectedValue;
                    auth.ContactPhoneNo = request.ConfigItems.Find(s => s.ConfigItemId == "TELEPHONE").SelectedValue;

                    // if user selected that the next stage should be ValuesStage, lets switch current state of the config to ValuesStage, alternativly we will route the config stage to DescriptionStage
                    if (request.ConfigItems.Find(s => s.ConfigItemId == "STAGE_SELECT").SelectedValue == "ValuesStage")
                    {
                        auth.ConfigStatus = "ValuesStage";
                    }
                    else {
                        auth.ConfigStatus = "DescriptionStage";
                    }
                    auth.Save();
                    return new Models.UpdateConfigResponse();
                }
                else if (auth.ConfigStatus == "ValuesStage")
                {
                    int intValue = 0;
                    if (int.TryParse(request.ConfigItems.Find(s => s.ConfigItemId == "INTVALUE").SelectedValue, out intValue))
                    {
                        if (intValue < 10)
                        {
                            return new Models.UpdateConfigResponse("Some Int Value must be greater than 10. This is just some validation on the integration side;");
                        }
                    }
                    else {
                        return new Models.UpdateConfigResponse("Some Int Value is not an int. WTF? ");
                    }
                    auth.ConfigStatus = "DescriptionStage";
                    auth.Save();
                    return new Models.UpdateConfigResponse();
                }
                else if (auth.ConfigStatus == "DescriptionStage")   // ON THE Final step we need to activate the config and set the status to CONFIG
                {
                    auth.IsConfigActive = true;
                    auth.ConfigStatus = "CONFIG";
                    auth.Save();
                    return new Models.UpdateConfigResponse();
                }
                else if (auth.ConfigStatus == "CONFIG" || auth.IsConfigActive)  // if the config is active the user can only change config properties
                {
                    auth.AccountName = request.ConfigItems.Find(s => s.ConfigItemId == "NAME").SelectedValue;
                    auth.AddressLine1 = request.ConfigItems.Find(s => s.ConfigItemId == "ADDRESS1").SelectedValue;
                    auth.Save();
                    return new Models.UpdateConfigResponse();
                }
                else {
                    return new Models.UpdateConfigResponse(auth.ConfigStatus + " is not handled");
                }
            }
            catch (Exception ex) {
                return new Models.UpdateConfigResponse("Unhandled exception saving user config: "+ ex.Message);
            }
        }

        [HttpPost()]
        [ActionName("ConfigDelete")]
        public Models.ConfigDeleteResponse ConfigDelete(Models.ConfigDeleteRequest request)
        {
            Classes.AuthorizationConfig auth = Classes.AuthorizationConfig.Load(request.AuthorizationToken);
            if (auth == null)
            {
                return new Models.ConfigDeleteResponse("Authorization failed for token " + request.AuthorizationToken);
            }
            Classes.AuthorizationConfig.Delete(request.AuthorizationToken);
            return new Models.ConfigDeleteResponse();
        }

        [HttpPost()]
        [ActionName("UserAvailableServices")]
        public Models.UserAvailableServicesResponse UserAvailableServices(Models.UserAvailableServicesRequest request)
        {
            Classes.AuthorizationConfig auth = Classes.AuthorizationConfig.Load(request.AuthorizationToken);
            if (auth == null)
            {
                return new Models.UserAvailableServicesResponse("Authorization failed for token " + request.AuthorizationToken);
            }
            return new Models.UserAvailableServicesResponse()
            {
                Services = Services.GetServices
            };            
        }

        [HttpPost()]
        [ActionName("ExtendedPropertyMapping")]
        public Models.ExtendedPropertyMappingResponse ExtendedPropertyMapping(Models.ExtendedPropertyMappingRequest request) {
            Classes.AuthorizationConfig auth = Classes.AuthorizationConfig.Load(request.AuthorizationToken);
            if (auth == null)
            {
                return new Models.ExtendedPropertyMappingResponse("Authorization failed for token " + request.AuthorizationToken);
            }
            return new Models.ExtendedPropertyMappingResponse()
            {
                Items = new List<Models.ExtendedPropertyMapping>() {
                    new Models.ExtendedPropertyMapping() {
                        PropertyName ="SafePlace1",
                        PropertyTitle="Safe Place note",
                        PropertyType = "ORDER",
                        PropertyDescription = "Safe place note for delivery"
                    },
                    new Models.ExtendedPropertyMapping() {
                        PropertyName ="ExtendedCover",
                        PropertyTitle="Extended Cover flag",
                        PropertyType = "ITEM",
                        PropertyDescription = "Identifies whether the item requires Extended Cover. Set to 1 if required."
                    }
                }
            };

        }

    }
}
