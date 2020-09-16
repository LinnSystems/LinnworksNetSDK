using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateDriver.Classes
{
    public class ConfigStage
    {              
        public string WizardStepDescription;
        public string WizardStepTitle;
        public List<ConfigItem> ConfigItems = new List<ConfigItem>();

        public static ConfigStage LoadStage(string StageName) {
            string stageConfigFileName = AppSettings.WizardStagesConfigPath+"\\"+StageName+".json";
            if (System.IO.File.Exists(stageConfigFileName)) {
                string json = System.IO.File.ReadAllText(stageConfigFileName);
                ConfigStage config = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigStage>(json);
                return config;
            }
            else {
                return new ConfigStage()
                {                    
                    WizardStepDescription = "",
                    WizardStepTitle = "Unknown stage"
                };
            }
        }
        public static void Save(string StageName, ConfigStage stage) {
            string stageConfigFileName = AppSettings.WizardStagesConfigPath + "\\" + StageName + ".json";
            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(stage);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(AppSettings.WizardStagesConfigPath + "\\" + StageName + ".json");
            sw.Write(jsonData);
            sw.Close();
        }
    }

    public class ConfigItem
    {
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
        public List<ConfigItemListItem> ListValues = new List<ConfigItemListItem>();
        public ConfigValueType ValueType = ConfigValueType.STRING;
    }

    public class ConfigItemListItem
    {
        public string Display;
        public string Value;
        public ConfigItemListItem() { }
        public ConfigItemListItem(string display, string value)
        {
            Display = display;
            Value = value;
        }
        public ConfigItemListItem(string value)
        {
            Display = value;
            Value = value;
        }
    }

    public enum ConfigValueType
    {
        STRING = 0,
        INT = 1,
        DOUBLE = 2,
        BOOLEAN = 3,
        PASSWORD = 4,
        LIST = 5
    }

}