using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateDriver.Classes
{
    public class CourierService
    {
        public string ServiceName;
        public string ServiceCode;
        public string ServiceTag;
        public string ServiceGroup;
        public Guid ServiceUniqueId;
        public List<ConfigItem> ConfigItems = new List<ConfigItem>();
        public List<ServiceProperty> ServiceProperty = new List<Classes.ServiceProperty>();
    }

    public class ServiceProperty {
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
    }




}