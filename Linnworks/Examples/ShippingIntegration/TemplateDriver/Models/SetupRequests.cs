using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateDriver.Models
{
    public class AddNewUserRequest 
    {
        public string Email;
        public string LinnworksUniqueIdentifier;
        public string AccountName;
    }

    public class UserConfigRequest : BaseClasses.BaseRequest
    {

    }

    public class UpdateConfigRequest : BaseClasses.BaseRequest
    {
        public string ConfigStatus;
        public List<Classes.UserStageConfigItem> ConfigItems = new List<Classes.UserStageConfigItem>();
    }
    public class ConfigDeleteRequest : BaseClasses.BaseRequest
    {

    }

    public class UserAvailableServicesRequest : BaseClasses.BaseRequest {

    }

    public class ExtendedPropertyMappingRequest : BaseClasses.BaseRequest
    {

    }


}