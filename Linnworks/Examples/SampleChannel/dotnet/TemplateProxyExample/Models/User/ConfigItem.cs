using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TemplateProxyExample.Models.User
{
    public class ConfigItem
    {
        public ConfigItem()
        {
            this.ValueType = ConfigValueType.STRING;
            this.ListValues = new List<ConfigItemListItem>();
        }

        public string ConfigItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GroupName { get; set; }
        public int SortOrder { get; set; }
        public string SelectedValue { get; set; }

        public string RegExValidation { get; set; }
        public string RegExError { get; set; }
        public bool MustBeSpecified { get; set; }
        public bool ReadOnly { get; set; }
        public List<ConfigItemListItem> ListValues { get; set; }
        public ConfigValueType ValueType { get; set; }

        public static implicit operator double(ConfigItem item)
        {
            double value = 0;
            double.TryParse(item.SelectedValue, out value);
            return value;
        }

        public static implicit operator int(ConfigItem item)
        {
            int value = 0;
            int.TryParse(item.SelectedValue, out value);
            return value;
        }

        public static implicit operator bool(ConfigItem item)
        {
            bool value = false;
            bool.TryParse(item.SelectedValue, out value);
            return value;
        }

        public static implicit operator string(ConfigItem item)
        {
            return item.SelectedValue;
        }
    }


    public class ConfigItemListItem
    {
        public string Display { get; set; }
        public string Value { get; set; }
        public ConfigItemListItem() { }
        public ConfigItemListItem(string display, string value)
        {
            Display = display;
            Value = value;
        }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConfigValueType
    {
        STRING,
        INT,
        DOUBLE,
        BOOLEAN,
        PASSWORD,
        LIST
    }
}