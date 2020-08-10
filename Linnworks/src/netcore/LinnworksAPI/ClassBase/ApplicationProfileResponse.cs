using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Represents Linnworks.net application subscription profile 
    /// </summary>
    public class ApplicationProfileResponse
	{
        /// <summary>
        /// Plan Tag as defined in your Application Configuration 
        /// </summary>
		public String PlanTag { get; set; }

        /// <summary>
        /// Plan Name as defined in your application Configuration 
        /// </summary>
		public String PlanName { get; set; }

        /// <summary>
        /// Date when the profile was signed up for, or resubscribed 
        /// </summary>
		public DateTime ActivationDate { get; set; }

        /// <summary>
        /// Last Payment date 
        /// </summary>
		public DateTime LastPaymentDate { get; set; }

        /// <summary>
        /// Next payment date 
        /// </summary>
		public DateTime NextPaymentDate { get; set; }

        /// <summary>
        /// When profile is due to expire 
        /// </summary>
		public DateTime ProfileExpires { get; set; }

        /// <summary>
        /// Indicates whether the payment profile is active for the application, if this is set to false it means the customer canceled the profile but the profile is still active due last payment made in the last month. 
        /// </summary>
		public Boolean IsProfileActive { get; set; }
	} 
}