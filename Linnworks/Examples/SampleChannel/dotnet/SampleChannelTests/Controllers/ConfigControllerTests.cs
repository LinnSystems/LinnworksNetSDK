using Microsoft.Extensions.Options;
using Moq;
using SampleChannel.Adapters;
using SampleChannel.Config;
using SampleChannel.Controllers;
using SampleChannel.Helpers;
using SampleChannel.Models;
using SampleChannel.Models.User;
using SampleChannelTests.Common;
using System;
using System.Linq;
using Xunit;

namespace SampleChannelTests.Controllers
{
    public class ConfigControllerTests
    {
        [Fact]
        public void AddNewUserNoEmailFailsTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new AddNewUserRequest
            {
                Email = "",
                AccountName = "TestAccount",
                LinnworksUniqueIdentifier = Guid.NewGuid()
            };

            var response = configController.AddNewUser(request);
            Assert.Equal("Invalid Email", response.Error);
        }

        [Fact]
        public void AddNewUserNoAccountNameFailsTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new AddNewUserRequest
            {
                Email = "test@test.com",
                AccountName = "",
                LinnworksUniqueIdentifier = Guid.NewGuid()
            };

            var response = configController.AddNewUser(request);
            Assert.Equal("Invalid AccountName", response.Error);
        }

        [Fact]
        public void AddNewUserNoUniqueIdentifierFailsTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new AddNewUserRequest
            {
                Email = "test@test.com",
                AccountName = "Test Account",
                LinnworksUniqueIdentifier = Guid.Empty
            };

            var response = configController.AddNewUser(request);
            Assert.Equal("Invalid LinnworksUniqueIdentifier", response.Error);
        }

        [Fact]
        public void AddNewUserTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new AddNewUserRequest
            {
                Email = "test@test.com",
                AccountName = "Test Account",
                LinnworksUniqueIdentifier = Guid.NewGuid()
            };

            var response = configController.AddNewUser(request);
            Assert.Null(response.Error);
            Assert.NotEmpty(response.AuthorizationToken);
        }

        [Fact]
        public void ConfigDeletedUserDoesNotExistTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new BaseRequest
            {
                AuthorizationToken = CommonTestData.InvalidAuthorizationToken
            };

            var response = configController.ConfigDeleted(request);
            Assert.Equal(CommonTestData.UserNotFoundError, response.Error);
        }

        [Fact]
        public void ConfigDeleteTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new BaseRequest
            {
                AuthorizationToken = CommonTestData.ValidAuthorizationToken
            };

            var response = configController.ConfigDeleted(request);
            Assert.Null(response.Error);
        }

        [Fact]
        public void ConfigTestUserDoesNotExistTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new BaseRequest
            {
                AuthorizationToken = CommonTestData.InvalidAuthorizationToken
            };

            var response = configController.ConfigTest(request);
            Assert.Equal(CommonTestData.UserNotFoundError, response.Error);
        }

        [Fact]
        public void ConfigTestTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new BaseRequest
            {
                AuthorizationToken = CommonTestData.ValidAuthorizationToken
            };

            var response = configController.ConfigTest(request);
            Assert.Null(response.Error);
        }

        [Fact]
        public void PaymentTagsUserDoesNotExistTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new BaseRequest
            {
                AuthorizationToken = CommonTestData.InvalidAuthorizationToken
            };

            var response = configController.PaymentTags(request);
            Assert.Equal(CommonTestData.UserNotFoundError, response.Error);
        }

        [Fact]
        public void PaymentTagsTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new BaseRequest
            {
                AuthorizationToken = CommonTestData.ValidAuthorizationToken
            };

            var response = configController.PaymentTags(request);
            Assert.Null(response.Error);
            Assert.Equal("paypal_verified", response.PaymentTags.First().Tag);
        }

        [Fact]
        public void ShippingTagsUserDoesNotExistTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new BaseRequest
            {
                AuthorizationToken = CommonTestData.InvalidAuthorizationToken
            };

            var response = configController.ShippingTags(request);
            Assert.Equal(CommonTestData.UserNotFoundError, response.Error);
        }

        [Fact]
        public void ShippingTagsTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new BaseRequest
            {
                AuthorizationToken = CommonTestData.ValidAuthorizationToken
            };

            var response = configController.ShippingTags(request);
            Assert.Null(response.Error);
            Assert.Equal("RM CLR01", response.ShippingTags.First().Tag);
        }

        [Fact]
        public void UserConfigUserDoesNotExistTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new BaseRequest
            {
                AuthorizationToken = CommonTestData.InvalidAuthorizationToken
            };

            var response = configController.UserConfig(request);
            Assert.Equal(CommonTestData.UserNotFoundError, response.Error);
        }

        [Fact]
        public void UserConfigTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new BaseRequest
            {
                AuthorizationToken = CommonTestData.ValidAuthorizationToken
            };

            var response = configController.UserConfig(request);
            Assert.Null(response.Error);
            Assert.Equal("AddCredentials", response.StepName);
            Assert.Equal("Example account name", response.AccountName);
            Assert.Equal("APIKey", response.ConfigItems.First().ConfigItemId);
        }

        [Fact]
        public void SaveConfigUserDoesNotExistTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new SaveUserConfigRequest
            {
                AuthorizationToken = CommonTestData.InvalidAuthorizationToken,
                StepName = "OrderSetup",
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
                        SelectedValue = "false",
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
                        SelectedValue = "false",
                        SortOrder = 2,
                        ValueType = ConfigValueType.BOOLEAN
                    }
                }
            };

            var response = configController.SaveConfigSave(request);
            Assert.Equal(CommonTestData.UserNotFoundError, response.Error);
        }

        [Fact]
        public void SaveConfigUserInvalidSteNameTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new SaveUserConfigRequest
            {
                AuthorizationToken = CommonTestData.ValidAuthorizationToken,
                StepName = "OrderSetup"
            };

            var response = configController.SaveConfigSave(request);
            Assert.StartsWith("Invalid step name expected ", response.Error);
        }

        [Fact]
        public void SaveConfigTest()
        {
            ConfigController configController = GetConfigControllerInstance();

            var request = new SaveUserConfigRequest
            {
                AuthorizationToken = CommonTestData.ValidAuthorizationToken,
                StepName = "AddCredentials",
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
                        SelectedValue = string.Empty,
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
                        SelectedValue = string.Empty,
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
                }
            };

            var response = configController.SaveConfigSave(request);
            Assert.Null(response.Error);
            Assert.Equal("OrderSetup", response.StepName);
            Assert.Equal("Example account name", response.AccountName);
            Assert.Equal(2, response.ConfigItems.Length);
        }


        private static ConfigController GetConfigControllerInstance()
        {
            var repository = new Mock<IRepository>();
            repository.Setup(x => x.Exists(CommonTestData.ValidAuthorizationToken)).Returns(true);
            repository.Setup(x => x.Exists(CommonTestData.InvalidAuthorizationToken)).Returns(false);
            repository.Setup(x => x.Load(It.IsAny<string>())).Returns("{\"Email\":\"string\", \"LinnworksUniqueIdentifier\":\"3fa85f64-5717-4562-b3fc-2c963f66afa6\", \"IsComplete\":false,\"StepName\":\"AddCredentials\", \"AccountName\":\"string\", \"IsConfigActive\":false,\"APIKey\":null,\"APISecretKey\":null,\"IsOauth\":true,\"PriceIncTax\":false,\"DownloadVirtualItems\":false,\"AuthorizationToken\":\"" + CommonTestData.ValidAuthorizationToken + "\"}");

            var config = new Mock<IOptions<AppSettings>>();
            config.Setup(x => x.Value.FileRepository).Returns(repository.Object);

            var configStages = new ConfigStages();

            return new ConfigController(new UserConfigAdapter(config.Object, configStages), configStages);
        }
    }
}
