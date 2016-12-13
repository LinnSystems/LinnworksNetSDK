using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateDriver.ConfigStageClasses
{
    public static class ValuesStage
    {
        public static Classes.ConfigStage GetValuesStage
        {
            get
            {
                return new Classes.ConfigStage()
                {
                    WizardStepDescription = "Some values you can enter on stage 1",
                    WizardStepTitle = "Stage 1 selected",
                    ConfigItems = new List<Classes.ConfigItem>() {
                        new Classes.ConfigItem() {
                                ConfigItemId = "STRINGVALUE",
                                Description="Some string value",
                                GroupName="",
                                MustBeSpecified = true,
                                Name="String value",
                                ReadOnly= false,
                                SelectedValue="Some default value",
                                SortOrder=1,
                                ValueType = Classes.ConfigValueType.STRING
                            },
                        new Classes.ConfigItem() {
                                ConfigItemId = "DOUBLE",
                                Description="Some double value",
                                GroupName="",
                                MustBeSpecified = true,
                                Name="Some double value",
                                ReadOnly= false,
                                SelectedValue="1.99",
                                SortOrder=2,
                                ValueType = Classes.ConfigValueType.DOUBLE
                            },
                        new Classes.ConfigItem() {
                                ConfigItemId = "INTVALUE",
                                Description="Some int value",
                                GroupName="",
                                MustBeSpecified = true,
                                Name="Some int value",
                                ReadOnly= false,
                                SelectedValue="1",
                                SortOrder=3,
                                ValueType = Classes.ConfigValueType.INT
                            },
                        new Classes.ConfigItem() {
                                ConfigItemId = "LISTVALUE",
                                Description="List value",
                                GroupName="",
                                MustBeSpecified = true,
                                Name="Some values",
                                ReadOnly= false,
                                SelectedValue="1",
                                SortOrder=4,
                                ValueType = Classes.ConfigValueType.LIST,
                                ListValues = new List<Classes.ConfigItemListItem>()
                                {
                                     new Classes.ConfigItemListItem() {
                                        Display = "One",
                                        Value = "1"
                                    },
                                    new Classes.ConfigItemListItem() {
                                        Display = "Two",
                                        Value = "2"
                                    },
                                }
                            },
                            new Classes.ConfigItem() {
                                ConfigItemId = "BOOLEANVALUE",
                                Description="True or false",
                                GroupName="",
                                MustBeSpecified = true,
                                Name="True or false",
                                ReadOnly= false,
                                SelectedValue="",
                                SortOrder=5,
                                ValueType = Classes.ConfigValueType.BOOLEAN
                            },
                    }
                };
            }
        }
    }
}