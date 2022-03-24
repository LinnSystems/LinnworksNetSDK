using SampleChannel.Models.User;
using System;

namespace SampleChannel.Adapters
{
    public class ConfigStages : IConfigStages 
    {
        public UserConfigResponse StageResponse(UserConfig userConfig, string errorMessage = "")
        {
            switch (Enum.Parse(typeof(ConfigStagesEnum), userConfig.StepName))
            {
                case ConfigStagesEnum.AddCredentials:
                    return this.GetAPICredentials(userConfig);
                case ConfigStagesEnum.OrderSetup:
                    return this.GetOrderStep(userConfig);
                case ConfigStagesEnum.UserConfig:
                    return this.GetConfigStep(userConfig);
            }

            return new UserConfigResponse { Error = errorMessage };
        }

        private UserConfigResponse GetAPICredentials(UserConfig userConfig)
        {
            return new UserConfigResponse
            {
                StepName = "AddCredentials",
                AccountName = "Example account name",
                WizardStepTitle = "Add Credentials",
                WizardStepDescription = "This is where you add your website credentials",
                ConfigItems = new[]
                {
                    new ConfigItem
                    {
                        ConfigItemId = "APIKey",
                        Description = "Website API Key",
                        GroupName = "API Credentials",
                        MustBeSpecified = true,
                        Name = "API Key",
                        ReadOnly = false,
                        SelectedValue = userConfig.APIKey ?? string.Empty,
                        SortOrder = 1,
                        ValueType = ConfigValueType.PASSWORD
                    },
                    new ConfigItem
                    {
                        ConfigItemId = "APISecretKey",
                        Description = "Website API Secret Key",
                        GroupName = "API Credentials",
                        MustBeSpecified = true,
                        Name = "API Secret Key",
                        ReadOnly = false,
                        SelectedValue = userConfig.APISecretKey ?? string.Empty,
                        SortOrder = 2,
                        ValueType = ConfigValueType.PASSWORD
                    },
                    new ConfigItem
                    {
                        ConfigItemId = "IsOauth",
                        Description = "Defines if the authentication type is Oauth",
                        GroupName = "API Settings",
                        MustBeSpecified = true,
                        Name = "Is Oauth",
                        ReadOnly = false,
                        SelectedValue = userConfig.IsOauth.ToString(),
                        SortOrder = 3,
                        ValueType = ConfigValueType.BOOLEAN
                    }
                }
            };
        }

        private UserConfigResponse GetOrderStep(UserConfig userConfig)
        {
            return new UserConfigResponse
            {
                StepName = "OrderSetup",
                AccountName = "Example account name",
                WizardStepTitle = "Order Setup",
                WizardStepDescription = "Definition of tax settings and items to return",
                ConfigItems = new[]
                {
                    new ConfigItem
                    {
                        ConfigItemId = "PriceIncTax",
                        Description = "Defines if the price of an item includes tax",
                        GroupName = "Tax",
                        MustBeSpecified = true,
                        Name = "Price Includes Tax",
                        ReadOnly = false,
                        SelectedValue = userConfig.PriceIncTax.ToString(),
                        SortOrder = 1,
                        ValueType = ConfigValueType.BOOLEAN
                    },
                    new ConfigItem
                    {
                        ConfigItemId = "DownloadVirtualItems",
                        Description = "Check to allow the download of virtual items",
                        GroupName = "Items",
                        MustBeSpecified = false,
                        Name = "Download Virtual Items",
                        ReadOnly = false,
                        SelectedValue = userConfig.DownloadVirtualItems.ToString(),
                        SortOrder = 2,
                        ValueType = ConfigValueType.BOOLEAN
                    }
                }
            };
        }

        private UserConfigResponse GetConfigStep(UserConfig userConfig)
        {
            // We don't return API Credentials, if they're wrong or invalid we go back to starting stage.
            return new UserConfigResponse
            {
                StepName = "UserConfig",
                AccountName = "Example account name",
                WizardStepTitle = "UserConfig",
                WizardStepDescription = "User Config",
                ConfigItems = new[]
                {
                    new ConfigItem
                    {
                        ConfigItemId = "IsOauth",
                        Description = "Defines if the authentication type is Oauth",
                        GroupName = "Order",
                        MustBeSpecified = true,
                        Name = "Is Oauth",
                        ReadOnly = false,
                        SelectedValue = userConfig.IsOauth.ToString(),
                        SortOrder = 1,
                        ValueType = ConfigValueType.BOOLEAN
                    },
                    new ConfigItem
                    {
                        ConfigItemId = "PriceIncTax",
                        Description = "Defines if the price of an item includes tax",
                        GroupName = "Tax",
                        MustBeSpecified = true,
                        Name = "Price Includes Tax",
                        ReadOnly = false,
                        SelectedValue = userConfig.PriceIncTax.ToString(),
                        SortOrder = 2,
                        ValueType = ConfigValueType.BOOLEAN
                    },
                    new ConfigItem
                    {
                        ConfigItemId = "DownloadVirtualItems",
                        Description = "Check to allow the download of virtual items",
                        GroupName = "Items",
                        MustBeSpecified = false,
                        Name = "Download Virtual Items",
                        ReadOnly = false,
                        SelectedValue = userConfig.DownloadVirtualItems.ToString(),
                        SortOrder = 3,
                        ValueType = ConfigValueType.BOOLEAN
                    }
                }
            };
        }
    }
}