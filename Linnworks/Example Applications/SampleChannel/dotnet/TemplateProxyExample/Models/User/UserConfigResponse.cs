using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.User
{
    public class UserConfigResponse : BaseResponse
    {
        public string StepName { get; set; }
        public string WizardStepDescription { get; set; }
        public string WizardStepTitle { get; set; }
        public ConfigItem[] ConfigItems { get; set; }
    }
}