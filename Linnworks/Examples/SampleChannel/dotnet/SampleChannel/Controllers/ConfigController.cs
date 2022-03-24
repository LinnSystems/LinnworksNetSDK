using System;
using Microsoft.AspNetCore.Mvc;
using SampleChannel.Adapters;

namespace SampleChannel.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private IUserConfigAdapter _userConfigAdapter;
        private IConfigStages _configStages;

        public ConfigController(IUserConfigAdapter userConfigAdapter, IConfigStages configStages)
        {
            _userConfigAdapter = userConfigAdapter;
            _configStages = configStages;
        }

        /// <summary>
        /// Create a new user configuration.
        /// </summary>
        /// <param name="request"><see cref="Models.User.AddNewUserRequest"/></param>
        /// <returns><see cref="Models.User.AddNewUserResponse"/></returns>
        [HttpPost]
        public Models.User.AddNewUserResponse AddNewUser([FromBody] Models.User.AddNewUserRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Email))
                return new Models.User.AddNewUserResponse { Error = "Invalid Email" };

            if (string.IsNullOrWhiteSpace(request.AccountName))
                return new Models.User.AddNewUserResponse { Error = "Invalid AccountName" };

            if (request.LinnworksUniqueIdentifier == Guid.Empty)
                return new Models.User.AddNewUserResponse { Error = "Invalid LinnworksUniqueIdentifier" };

            var userConfig = this._userConfigAdapter.CreateNew(request.Email, request.LinnworksUniqueIdentifier, request.AccountName);

            return new Models.User.AddNewUserResponse
            {
                AuthorizationToken = userConfig.AuthorizationToken
            };
        }

        /// <summary>
        /// This call is made when the channel config is deleted from Linnworks. Note that this is
        /// a notification of deletion, if there is an error the config will still be deleted from Linnworks.
        /// </summary>
        /// <param name="request"><see cref="Models.BaseRequest"/></param>
        /// <returns><see cref="Models.BaseResponse"/></returns>
        [HttpPost]
        public Models.BaseResponse ConfigDeleted([FromBody] Models.BaseRequest request)
        {
            try
            {
                this._userConfigAdapter.Delete(request.AuthorizationToken);

                return new Models.BaseResponse();
            }
            catch (Exception ex)
            {
                return new Models.BaseResponse { Error = ex.Message };
            }
        }

        /// <summary>
        /// This call is made when the test button is pressed in the user config. It should test the
        /// customer's integration is valid. It may also be used in automation jobs to check if there
        /// #is a constant or global error.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public Models.BaseResponse ConfigTest([FromBody] Models.BaseRequest request)
        {
            try
            {
                var user = this._userConfigAdapter.Load(request.AuthorizationToken);

                //Would normally do something here to test.

                return new Models.BaseResponse();
            }
            catch (Exception ex)
            {
                return new Models.BaseResponse { Error = ex.Message };
            }
        }

        /// <summary>
        /// This call is expected to return an array of shipping methods friendly names and their tags
        /// to generate a pre-populated list in the config shipping mapping screen.
        /// </summary>
        /// <param name="request"><see cref="Models.BaseRequest"/></param>
        /// <returns><see cref="Models.Payment.PaymentTagResponse"/></returns>
        [HttpPost]
        public Models.Payment.PaymentTagResponse PaymentTags([FromBody] Models.BaseRequest request)
        {
            try
            {
                var user = this._userConfigAdapter.Load(request.AuthorizationToken);

                return new Models.Payment.PaymentTagResponse
                {
                    PaymentTags = new[]
                    {
                    new Models.Payment.PaymentTag { FriendlyName = "PayPal",  Site = "", Tag = "paypal_verified" },
                    new Models.Payment.PaymentTag { FriendlyName = "Credit Card - Master Card",  Site = "", Tag = "mastercard" },
                    new Models.Payment.PaymentTag { FriendlyName = "Credit Card - Visa",  Site = "", Tag = "visa_credit" },
                    new Models.Payment.PaymentTag { FriendlyName = "Credit Card - Unknown",  Site = "", Tag = "credit_unknown" },
                    new Models.Payment.PaymentTag { FriendlyName = "Bank payments",  Site = "", Tag = "bank" },
                }
                };
            }
            catch (Exception ex)
            {
                return new Models.Payment.PaymentTagResponse { Error = ex.Message };
            }
        }

        /// <summary>
        /// This call is expected to return an array of shipping methods friendly names and their tags
        /// to generate a pre-populated list in the config shipping mapping screen.
        /// </summary>
        /// <param name="request"><see cref="Models.BaseRequest"/></param>
        /// <returns><see cref="Models.Shipping.ShippingTagResponse"/></returns>
        [HttpPost]
        public Models.Shipping.ShippingTagResponse ShippingTags([FromBody] Models.BaseRequest request)
        {
            try
            {
                var user = this._userConfigAdapter.Load(request.AuthorizationToken);

                return new Models.Shipping.ShippingTagResponse
                {
                    ShippingTags = new[]
                    {
                    new Models.Shipping.ShippingTag { FriendlyName = "Royal Mail First Class",  Site = "", Tag = "RM CLR01" },
                    new Models.Shipping.ShippingTag { FriendlyName = "Royal Mail Special Delivery",  Site = "", Tag = "RM_SpecialDelivery_9am" },
                    new Models.Shipping.ShippingTag { FriendlyName = "DPD - Next Day",  Site = "", Tag = "dpd" },
                    new Models.Shipping.ShippingTag { FriendlyName = "Fedex - Ground",  Site = "", Tag = "fedex_ground" },
                    new Models.Shipping.ShippingTag { FriendlyName = "Some other service",  Site = "", Tag = "matrix_rate_10221" },
                }
                };
            }
            catch (Exception ex)
            {
                return new Models.Shipping.ShippingTagResponse { Error = ex.Message };
            }
        }

        /// <summary>
        /// This request is made in two situations:
        /// 
        /// Firstly when a customer is going through the integration wizard to integrate the channel.
        /// To complete the wizard returns "UserConfig" as the step name and this will indicate the
        /// wizard is complete.
        /// 
        /// The second instance is when the config is loaded the call is made to load any dynamic
        /// ConfigItems that may be required to show on the Linnworks config UI.SaveConfigEndpoint
        /// will be called on each wizard step and when the config is saved.
        /// 
        /// If the config is loaded and the StepName is not "UserConfig" it will load the config
        /// wizard and take them through the stages until "UserConfig" is returned.This can be
        /// especially useful if the user is required to go through additional steps down the line.
        /// </summary>
        /// <param name="request"><see cref="Models.BaseRequest"/></param>
        /// <returns><see cref="Models.User.UserConfigResponse"/></returns>
        [HttpPost]
        public Models.User.UserConfigResponse UserConfig([FromBody] Models.BaseRequest request)
        {
            try
            {
                var userConfig = this._userConfigAdapter.Load(request.AuthorizationToken);

                return _configStages.StageResponse(userConfig, "User config is at invalid stage");
            }
            catch (Exception ex)
            {
                return new Models.User.UserConfigResponse { Error = ex.Message };
            }
        }

        /// <summary>
        /// This request is made in two situations:
        /// 
        /// At the end of every config wizard step as a customer enters / edits the fields and on the
        /// config screen if custom config items are supplied back when the step name is "UserConfig".
        /// 
        /// Linnworks will provide the entire object that was provided back with the only field ever
        /// changing being the SelectedValue.This is passed back cast as string as fields may be of
        /// many different types.
        /// </summary>
        /// <param name="request"><see cref="Models.User.SaveUserConfigRequest"/></param>
        /// <returns><see cref="Models.User.UserConfigResponse"/></returns>
        [HttpPost]
        public Models.User.UserConfigResponse SaveConfigSave([FromBody] Models.User.SaveUserConfigRequest request)
        {
            try
            {
                var userConfig = this._userConfigAdapter.Load(request.AuthorizationToken);

                if (request.StepName != userConfig.StepName)
                    return new Models.User.UserConfigResponse { Error = string.Format("Invalid step name expected {0}", userConfig.StepName) };

                return this._userConfigAdapter.Save(userConfig, request.ConfigItems);
            }
            catch (Exception ex)
            {
                return new Models.User.UserConfigResponse { Error = ex.Message };
            }
        }
    }
}
