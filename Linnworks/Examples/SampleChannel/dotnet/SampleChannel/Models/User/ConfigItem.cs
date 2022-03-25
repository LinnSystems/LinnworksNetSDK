using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace SampleChannel.Models.User
{
    public class ConfigItem
    {
        public ConfigItem()
        {
            this.ValueType = ConfigValueType.STRING;
            this.ListValues = new List<ConfigItemListItem>();
        }

        /// <summary>
        /// Unique id of either the wizard item or config item.
        /// </summary>
        public string ConfigItemId { get; set; }

        /// <summary>
        /// Visible name on the wizard or config.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the config item or wizard item. Will be displayed in tooltips 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Used to group the config or wizard items.
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Order of config item to be displayed on the UI.
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Selected value either default value or value selected in the UI when sent back.
        /// </summary>
        public string SelectedValue { get; set; }

        /// <summary>
        /// JavaScript Regex validation script.
        /// </summary>
        public string RegExValidation { get; set; }

        /// <summary>
        /// Message that will be shown to the custmer if wizard field validation does not go through.
        /// </summary>
        public string RegExError { get; set; }

        /// <summary>
        /// Defines if the user must enter this value in the wizard or config.
        /// </summary>
        public bool MustBeSpecified { get; set; }

        /// <summary>
        /// Defines if the field is a visible only field.
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// List values <see cref="ConfigItemListItem"/>
        /// </summary>
        public List<ConfigItemListItem> ListValues { get; set; }

        /// <summary>
        /// Config value type <see cref="ConfigValueType"/>
        /// </summary>
        public ConfigValueType ValueType { get; set; }

        /// <summary>
        /// Determines whether a header-level attribute (e.g. InventorySync) should be hidden from the config.
        /// Used in conjunction with the Name property, where Name identifies the attribute to hide.
        /// </summary>
        public bool HidesHeaderAttribute { get; set; }

        public static implicit operator double(ConfigItem item)
        {
            _ = double.TryParse(item.SelectedValue, out double value);
            return value;
        }

        public static implicit operator int(ConfigItem item)
        {
            _ = int.TryParse(item.SelectedValue, out int value);
            return value;
        }

        public static implicit operator bool(ConfigItem item)
        {
            _ = bool.TryParse(item.SelectedValue, out bool value);
            return value;
        }

        public static implicit operator string(ConfigItem item)
        {
            return item.SelectedValue;
        }
    }


    public class ConfigItemListItem
    {
        /// <summary>
        /// Visible value.
        /// </summary>
        public string Display { get; set; }

        /// <summary>
        /// Value String SelectedValue.
        /// </summary>
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