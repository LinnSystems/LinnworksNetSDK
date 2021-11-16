using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.User
{
    public class UserConfigResponse : BaseResponse
    {
        /// <summary>
        /// Current Step name, if returned "UserConfig" it will assume that the wizard is complete.
        /// </summary>
        public string StepName { get; set; }

        /// <summary>
        /// Account name being integrated into the system. Will never change and on integration it
        /// is suggest that duplicates are checked for. Nb. Customers may expect to have multiple
        /// integrations of the same channel in Linnworks.
        /// </summary>
        public string AccountName { get; set; } 

        /// <summary>
        /// Description of the current wizard step.
        /// </summary>
        public string WizardStepDescription { get; set; }

        /// <summary>
        /// User visible title displayed on the integration wizard.
        /// </summary>
        public string WizardStepTitle { get; set; }

        /// <summary>
        /// Config items.
        /// </summary>
        public ConfigItem[] ConfigItems { get; set; }
    }
}