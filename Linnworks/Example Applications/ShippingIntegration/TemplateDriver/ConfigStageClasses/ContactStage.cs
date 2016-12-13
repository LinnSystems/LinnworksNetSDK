using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateDriver.ConfigStageClasses
{
    public static class ContactStage
    {
        public static Classes.ConfigStage GetContactStage
        {
            get
            {
                return new Classes.ConfigStage()
                {
                    WizardStepDescription = "Customer enters some details at this stage",
                    WizardStepTitle="Customer Details",
                    ConfigItems = new List<Classes.ConfigItem>() {
                        new Classes.ConfigItem() {
                                ConfigItemId = "NAME",
                                Description="Contact name",
                                GroupName="Sender Address",
                                MustBeSpecified = true,
                                Name="Contact Name",
                                ReadOnly= false,
                                SelectedValue="",
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
                                SelectedValue="",
                                SortOrder=3,
                                ValueType = Classes.ConfigValueType.STRING
                            },
                            new Classes.ConfigItem() {
                                ConfigItemId = "ADDRESS2",
                                Description="Address line 2",
                                GroupName="Sender Address",
                                MustBeSpecified = false,
                                Name="Address 2",
                                ReadOnly= false,
                                SelectedValue="",
                                SortOrder=3,
                                ValueType = Classes.ConfigValueType.STRING
                            },
                            new Classes.ConfigItem() {
                                ConfigItemId = "ADDRESS3",
                                Description="Address line 3",
                                GroupName="Sender Address",
                                MustBeSpecified = false,
                                Name="Address 3",
                                ReadOnly= false,
                                SelectedValue="",
                                SortOrder=4,
                                ValueType = Classes.ConfigValueType.STRING
                            },
                            new Classes.ConfigItem() {
                                ConfigItemId = "CITY",
                                Description="Town/City name",
                                GroupName="Sender Address",
                                MustBeSpecified = true,
                                Name="Town/City",
                                ReadOnly= false,
                                SelectedValue="",
                                SortOrder=5,
                                ValueType = Classes.ConfigValueType.STRING
                            },
                            new Classes.ConfigItem() {
                                ConfigItemId = "REGION",
                                Description="Region",
                                GroupName="Sender Address",
                                MustBeSpecified = true,
                                Name="Region",
                                ReadOnly= false,
                                SelectedValue="",
                                SortOrder=6,
                                ValueType = Classes.ConfigValueType.STRING
                            },
                            new Classes.ConfigItem() {
                                ConfigItemId = "COUNTRY",
                                Description="Country",
                                GroupName="Sender Address",
                                MustBeSpecified = true,
                                Name="Country",
                                ReadOnly= false,
                                SelectedValue="GB",
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
                            },
                            new Classes.ConfigItem() {
                                ConfigItemId = "TELEPHONE",
                                Description="Contact telephone number",
                                GroupName="Sender Address",
                                MustBeSpecified = true,
                                Name="Contact Telephone",
                                ReadOnly= false,
                                SelectedValue="",
                                SortOrder=8,
                                ValueType = Classes.ConfigValueType.STRING
                            },
                            new Classes.ConfigItem() {
                                ConfigItemId = "STAGE_SELECT",
                                Description="Which stage do you want to select next",
                                GroupName="Next Config Stage",
                                MustBeSpecified = true,
                                Name="Next Stage",
                                ReadOnly= false,
                                SelectedValue="ValuesStage",
                                SortOrder=9,
                                ValueType = Classes.ConfigValueType.LIST,
                                ListValues = new List<Classes.ConfigItemListItem>()
                                {
                                    new Classes.ConfigItemListItem() {
                                        Display = "Go to Value stage",
                                        Value = "ValuesStage"
                                    },
                                    new Classes.ConfigItemListItem() {
                                        Display = "Go to Description stage",
                                        Value = "DescriptionStage"
                                    }
                                }
                            }
                    }
                };
            }
        }
     }
}