using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateDriver.ConfigStageClasses
{
    public static class DescriptionStage
    {
        public static Classes.ConfigStage GetDescriptionStage
        {
            get
            {
                return new Classes.ConfigStage()
                {
                    WizardStepDescription = "Here you can insert a link to a registration for form example <a href='http://www.gmail.com?token=[{token}]'>Register Here</a> where you can replace the token with pass through token.",
                    WizardStepTitle="Very flexible description and instructions",
                    ConfigItems = new List<Classes.ConfigItem>() {                        
                            new Classes.ConfigItem() {
                                ConfigItemId = "BOOLEANVALUE",
                                Description="Some question?",
                                GroupName="",
                                MustBeSpecified = true,
                                Name="Some question",
                                ReadOnly= false,
                                SelectedValue="",
                                SortOrder=1,
                                ValueType = Classes.ConfigValueType.BOOLEAN
                            }
                    }
                };
            }            
        }
    }
}