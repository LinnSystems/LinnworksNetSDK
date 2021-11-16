using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.Extensions.Configuration;
using TemplateProxyExample.Helpers;

namespace TemplateProxyExample.Models.User
{
    public class UserConfig : BaseRequest
    {
        private IRepository fileRepository;

        public UserConfig(IRepository fileRepository) 
        {
            this.IsOauth = true;
            this.StepName = ConfigStagesEnum.AddCredentials.ToString();
            this.fileRepository = fileRepository;
        }

        public UserConfig(IRepository fileRepository, string authorizationToken)
        {
            this.fileRepository = fileRepository;
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

            if(this.fileRepository.Exists(this.AuthorizationToken))
            { 
                string json = this.fileRepository.Load(this.AuthorizationToken);
                Newtonsoft.Json.JsonConvert.PopulateObject(json, this);
            }
            else
            {
                throw new Exception("User not found");
            }
        }

        public void Delete()
        {
            if (this.fileRepository.Exists(this.AuthorizationToken))
            {
                this.fileRepository.Delete(this.AuthorizationToken);
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
            var output = Newtonsoft.Json.JsonConvert.SerializeObject(this);

            this.fileRepository.Save(this.AuthorizationToken, output);
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