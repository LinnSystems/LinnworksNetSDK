using Moq;
using System;
using TemplateProxyExample.Helpers;
using TemplateProxyExample.Models.User;
using TemplateProxyExampleTests.Common;
using Xunit;

namespace TemplateProxyExampleTests.Models
{
    public class UserConfigTests
    {
        [Fact]
        public void LoadNoAuthTokenTest()
        {
            var configRepository = this.GetConfigRepository();
            Assert.Throws<ArgumentNullException>(() => new UserConfig(configRepository, string.Empty));
        }

        [Fact]
        public void LoadUserDoesntExistTest()
        {
            var configRepository = this.GetConfigRepository();
            Assert.Throws<Exception>(() => new UserConfig(configRepository, CommonTestData.InvalidAuthorizationToken));
        }

        [Fact]
        public void LoadTest()
        {
            var configRepository = this.GetConfigRepository();
            var userConfig = new UserConfig(configRepository, CommonTestData.ValidAuthorizationToken);

            Assert.Equal(new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), userConfig.LinnworksUniqueIdentifier);
            Assert.Equal("AddCredentials", userConfig.StepName);
        }

        [Fact]
        public void SaveTest()
        {
            var configRepository = this.GetConfigRepository();
            var userConfig = new UserConfig(configRepository, CommonTestData.ValidAuthorizationToken);

            var configItems = new []
            {
                new ConfigItem
                    {
                        ConfigItemId = "APIKey",
                        Description = "Website API Key",
                        GroupName = "API Credentials",
                        MustBeSpecified = true,
                        Name = "API Key",
                        ReadOnly = false,
                        SelectedValue = "Test API key",
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
                        SelectedValue = "Test Secret Key",
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
                        SelectedValue = "true",
                        SortOrder = 3,
                        ValueType = ConfigValueType.BOOLEAN
                    }
            };

            var response = userConfig.Save(configItems);

            Assert.Equal("Test API key", userConfig.APIKey);
            Assert.Equal("Test Secret Key", userConfig.APISecretKey);
            Assert.True(userConfig.IsOauth);
        }

        private IRepository GetConfigRepository()
        {
            var repository = new Mock<IRepository>();
            repository.Setup(x => x.Exists(CommonTestData.ValidAuthorizationToken)).Returns(true);
            repository.Setup(x => x.Exists(CommonTestData.InvalidAuthorizationToken)).Returns(false);
            repository.Setup(x => x.Load(It.IsAny<string>())).Returns("{\"Email\":\"string\", \"LinnworksUniqueIdentifier\":\"3fa85f64-5717-4562-b3fc-2c963f66afa6\", \"IsComplete\":false,\"StepName\":\"AddCredentials\", \"AccountName\":\"string\", \"IsConfigActive\":false,\"APIKey\":null,\"APISecretKey\":null,\"IsOauth\":true,\"PriceIncTax\":false,\"DownloadVirtualItems\":false,\"AuthorizationToken\":\"" + CommonTestData.ValidAuthorizationToken + "\"}");
            return repository.Object;
        }
    }
}
