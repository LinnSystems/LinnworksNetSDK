using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.User
{
    public class SaveUserConfigRequest : BaseRequest
    {
        public string StepName { get; set; }

        public ConfigItem[] ConfigItems { get; set; }
    }
}