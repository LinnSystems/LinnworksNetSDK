using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.Extensions.Configuration;

namespace TemplateProxyExample.Models.User
{
    public class UserConfig : BaseRequest
    {
        private string userStoreLocation;

        public UserConfig(string userStoreLocation) 
        {
            this.IsOauth = true;
            this.StepName = ConfigStagesEnum.AddCredentials.ToString();
            this.userStoreLocation = userStoreLocation;
        }

        public UserConfig(string userStoreLocation, string authorizationToken)
        {
            this.userStoreLocation = userStoreLocation;
            this.AuthorizationToken = authorizationToken;
            this.Load();
        }

        public string Email { get; set; }

        public Guid LinnworksUniqueIdentifier { get; set; }

        public bool IsComplete { get; set; }
        public string StepName { get; set; }
        public string AccountName { get; set; }
        public bool IsConfigActive { get; set; }
        public string APIKey { get; set; }
        public string APISecretKey { get; set; }
        public bool IsOauth { get; set; }
        public bool PriceIncTax { get; set; }
        public bool DownloadVirtualItems { get; set; }

        public void Load()
        {
            if (string.IsNullOrWhiteSpace(this.AuthorizationToken))
                throw new ArgumentNullException("authorizationToken");

            string path = string.Concat(this.userStoreLocation, "\\", this.AuthorizationToken, ".json");

            if (System.IO.File.Exists(path))
            {
                string json = System.IO.File.ReadAllText(path);
                Newtonsoft.Json.JsonConvert.PopulateObject(json, this);
            }
            else
            {
                throw new Exception("User not found");
            }
        }

        public void Delete()
        {
            string path = string.Concat(this.userStoreLocation, "\\", this.AuthorizationToken, ".json");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public void CreateNew(string email, Guid linnworksUniqueIdentifier, string accountName)
        {
            this.AuthorizationToken = Guid.NewGuid().ToString("N");
            this.Email = email;
            this.LinnworksUniqueIdentifier = linnworksUniqueIdentifier;
            this.AccountName = accountName;
            this.Save();
        }

        private void Save()
        {
            string path = string.Concat(this.userStoreLocation, "\\", this.AuthorizationToken, ".json");
            var output = Newtonsoft.Json.JsonConvert.SerializeObject(this);

            File.WriteAllText(path, output);
        }

        public UserConfigResponse Save(ConfigItem[] configItems)
        {
            var step = Enum.Parse(typeof(ConfigStagesEnum), this.StepName);
            switch (step)
            {
                case ConfigStagesEnum.AddCredentials:
                    this.APIKey = configItems.FirstOrDefault(s => s.ConfigItemId == "APIKey");
                    this.APISecretKey = configItems.FirstOrDefault(s => s.ConfigItemId == "APISecretKey");
                    this.IsOauth = configItems.FirstOrDefault(s => s.ConfigItemId == "IsOauth");
                    this.StepName = ConfigStagesEnum.OrderSetup.ToString();
                    break;
                case ConfigStagesEnum.OrderSetup:
                    this.PriceIncTax = configItems.FirstOrDefault(s => s.ConfigItemId == "PriceIncTax");
                    this.DownloadVirtualItems = configItems.FirstOrDefault(s => s.ConfigItemId == "DownloadVirtualItems");
                    this.StepName = ConfigStagesEnum.UserConfig.ToString();
                    break;
                case ConfigStagesEnum.UserConfig:
                    this.IsOauth = configItems.FirstOrDefault(s => s.ConfigItemId == "IsOauth");
                    this.PriceIncTax = configItems.FirstOrDefault(s => s.ConfigItemId == "PriceIncTax");
                    this.DownloadVirtualItems = configItems.FirstOrDefault(s => s.ConfigItemId == "DownloadVirtualItems");
                    break;
            }

            this.Save();

            var configStage = new ConfigStages(this);

            return configStage.StageResponse();
        }
    }
}