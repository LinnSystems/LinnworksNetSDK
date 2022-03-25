using Microsoft.Extensions.Options;
using SampleChannel.Config;
using SampleChannel.Helpers;
using SampleChannel.Models.User;
using System;
using System.Linq;

namespace SampleChannel.Adapters
{
    public class UserConfigAdapter : IUserConfigAdapter
    {
        private readonly IRepository _fileRepository;
        private readonly IConfigStages _configStages;

        public UserConfigAdapter(IOptions<AppSettings> config, IConfigStages configStages)
        {
            _fileRepository = config.Value.FileRepository;
            _configStages = configStages;
        }

        /// <inheritdoc />
        public UserConfig Load(string authorizationToken)
        {
            if (string.IsNullOrWhiteSpace(authorizationToken))
                throw new ArgumentNullException("authorizationToken");

            if (_fileRepository.Exists(authorizationToken))
            {
                string json = _fileRepository.Load(authorizationToken);
                var userConfig= Newtonsoft.Json.JsonConvert.DeserializeObject<UserConfig>(json);
                return userConfig;
            }
            else
            {
                throw new Exception("User not found");
            }
        }

        /// <inheritdoc />
        public void Delete(string authorizationToken)
        {
            if (_fileRepository.Exists(authorizationToken))
            {
                _fileRepository.Delete(authorizationToken);
            }
            else
            {
                throw new Exception("User not found");
            }
        }

        /// <inheritdoc />
        public UserConfig CreateNew(string email, Guid linnworksUniqueIdentifier, string accountName)
        {
            var userConfig = new UserConfig
            {
                AuthorizationToken = Guid.NewGuid().ToString("N"),
                Email = email,
                LinnworksUniqueIdentifier = linnworksUniqueIdentifier,
                AccountName = accountName
            };
            this.Save(userConfig);
            return userConfig;
        }

        /// <inheritdoc />
        public UserConfigResponse Save(UserConfig userConfig, ConfigItem[] configItems)
        {
            var step = Enum.Parse(typeof(ConfigStagesEnum), userConfig.StepName);
            switch (step)
            {
                case ConfigStagesEnum.AddCredentials:
                    userConfig.APIKey = configItems.FirstOrDefault(s => s.ConfigItemId == "APIKey");
                    userConfig.APISecretKey = configItems.FirstOrDefault(s => s.ConfigItemId == "APISecretKey");
                    userConfig.IsOauth = configItems.FirstOrDefault(s => s.ConfigItemId == "IsOauth");
                    userConfig.StepName = ConfigStagesEnum.OrderSetup.ToString();
                    break;
                case ConfigStagesEnum.OrderSetup:
                    userConfig.PriceIncTax = configItems.FirstOrDefault(s => s.ConfigItemId == "PriceIncTax");
                    userConfig.DownloadVirtualItems = configItems.FirstOrDefault(s => s.ConfigItemId == "DownloadVirtualItems");
                    userConfig.StepName = ConfigStagesEnum.UserConfig.ToString();
                    break;
                case ConfigStagesEnum.UserConfig:
                    userConfig.IsOauth = configItems.FirstOrDefault(s => s.ConfigItemId == "IsOauth");
                    userConfig.PriceIncTax = configItems.FirstOrDefault(s => s.ConfigItemId == "PriceIncTax");
                    userConfig.DownloadVirtualItems = configItems.FirstOrDefault(s => s.ConfigItemId == "DownloadVirtualItems");
                    break;
            }

            this.Save(userConfig);

            return _configStages.StageResponse(userConfig);
        }

        private void Save(UserConfig userConfig)
        {
            var output = Newtonsoft.Json.JsonConvert.SerializeObject(userConfig);

            this._fileRepository.Save(userConfig.AuthorizationToken, output);
        }

    }
}
