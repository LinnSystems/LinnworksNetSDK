using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateDriver.ConfigStageClasses
{
    public static class UserConfigStage
    {
        public static Classes.ConfigStage GetUserConfigStage(Classes.AuthorizationConfig authConfig) {
                return new Classes.ConfigStage()
                {
                    WizardStepDescription = "Customer config can be changed",
                    WizardStepTitle = "Customer Details",
                    ConfigItems = new List<Classes.ConfigItem>() {
                        new Classes.ConfigItem() {
                                ConfigItemId = "NAME",
                                Description="Contact name",
                                GroupName="Sender Address",
                                MustBeSpecified = true,
                                Name="Contact Name",
                                ReadOnly= false,
                                SelectedValue=authConfig.AccountName,
                                SortOrder=1,
                                ValueType = Classes.ConfigValueType.STRING
                            },
                            new Classes.ConfigItem() {
                                ConfigItemId = "ADDRESS1",
                                Description="Address line 1",
                                GroupName="Sender Address",
                                MustBeSpecified = true,
                                Name="Address 1",
                                ReadOnly= false,
                                SelectedValue=authConfig.AddressLine1,
                                SortOrder=3,
                                ValueType = Classes.ConfigValueType.STRING
                            },                           
                            new Classes.ConfigItem() {
                                ConfigItemId = "COUNTRY",
                                Description="Country",
                                GroupName="Sender Address",
                                MustBeSpecified = true,
                                Name="Country",
                                ReadOnly= true,
                                SelectedValue=authConfig.CountryCode,
                                SortOrder=7,
                                ValueType = Classes.ConfigValueType.LIST,
                                ListValues = new List<Classes.ConfigItemListItem>()
                                {
                                    new Classes.ConfigItemListItem() {
                                        Display = "United Kingdom",
                                        Value = "GB"
                                    },
                                    new Classes.ConfigItemListItem() {
                                        Display = "Germany",
                                        Value = "DE"
                                    },
                                    new Classes.ConfigItemListItem() {
                                        Display = "France",
                                        Value = "FR"
                                    },
                                    new Classes.ConfigItemListItem() {
                                        Display = "United States",
                                        Value = "US"
                                    }
                                }
                            }                            
                    }
                };
        }
    }
}