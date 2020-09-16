using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateDriver.Models
{
    public class AddNewUserResponse : BaseClasses.BaseResponse
    {
        public string AuthorizationToken;
        public AddNewUserResponse(string error) : base(error) { }
        public AddNewUserResponse() : base() { }
    }

    public class UserConfigResponse : BaseClasses.BaseResponse
    {
        public Boolean IsConfigActive;
        public string ConfigStatus;
        public Classes.ConfigStage ConfigStage;
        public UserConfigResponse(string error) : base(error) { }
        public UserConfigResponse() : base() { }
    }

    public class UpdateConfigResponse : BaseClasses.BaseResponse
    {

        public UpdateConfigResponse(string error) : base(error) { }
        public UpdateConfigResponse() : base() { }
    }

    public class ConfigDeleteResponse : BaseClasses.BaseResponse
    {

        public ConfigDeleteResponse(string error) : base(error) { }
        public ConfigDeleteResponse() : base() { }
    }

    public class UserAvailableServicesResponse : BaseClasses.BaseResponse
    {
        public UserAvailableServicesResponse(string error) : base(error) { }
        public UserAvailableServicesResponse() : base() { }

        public List<Classes.CourierService> Services = new List<Classes.CourierService>();

        internal static List<Classes.CourierService> LoadServiceFile() {
            List<Classes.CourierService> output = new List<Classes.CourierService>();
            if (System.IO.File.Exists(AppSettings.WizardStagesConfigPath + "\\services.json"))
            {
                string json = System.IO.File.ReadAllText(AppSettings.WizardStagesConfigPath + "\\services.json");
                output = JsonConvert.DeserializeObject<List<Classes.CourierService>>(json);
            }
            return output;
        }
    }

    public class ExtendedPropertyMappingResponse : BaseClasses.BaseResponse
    {
        public ExtendedPropertyMappingResponse(string error) : base(error) { }
        public ExtendedPropertyMappingResponse() : base() { }
        public List<ExtendedPropertyMapping> Items = new List<ExtendedPropertyMapping>();
    }

    public class ExtendedPropertyMapping {
        public string PropertyTitle = "";
        public string PropertyName = "";
        public string PropertyDescription = "";
        public string PropertyType = ""; // ITEM or ORDER        
    }



}