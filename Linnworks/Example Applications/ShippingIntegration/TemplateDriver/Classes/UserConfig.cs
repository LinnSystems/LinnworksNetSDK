using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateDriver.Classes
{

    public class UserConfig {
        public List<UserStageConfig> StageConfigs = new List<UserStageConfig>();

        public static UserConfig Load(string AuthorizationToken)
        {
            string folderName = AppSettings.WizardStagesConfigPath + "\\" + AuthorizationToken;
            if (!System.IO.Directory.Exists(folderName))
            {
                System.IO.Directory.CreateDirectory(folderName);
            }
            string fileName = AppSettings.WizardStagesConfigPath + "\\" + AuthorizationToken + "\\stageConfigs.json";
            if (System.IO.File.Exists(fileName))
            {
                string json = System.IO.File.ReadAllText(fileName);
                return Newtonsoft.Json.JsonConvert.DeserializeObject<UserConfig>(json);
            }
            else {
                return new UserConfig();
            }
        }

    }
    public class UserStageConfig
    {
        public string ConfigStage;
        public List<UserStageConfigItem> Items = new List<UserStageConfigItem>();
    }


    public class UserStageConfigItem {
        public string ConfigItemId;
        public string SelectedValue;
    }
}