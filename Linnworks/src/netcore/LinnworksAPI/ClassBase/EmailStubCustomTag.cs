using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// An email stub may have custom tag created either by manual entry by the user or automatically added by the stub generation routine. 
    /// </summary>
    public class EmailStubCustomTag
	{
        /// <summary>
        /// Row id 
        /// </summary>
		public Int32 pkEmailStubTagId { get; set; }

        /// <summary>
        /// Relation to email_stub 
        /// </summary>
		public Int32 fkEmailStubId { get; set; }

        /// <summary>
        /// Name of the tag 
        /// </summary>
		public String TagName { get; set; }

        /// <summary>
        /// Value which will be inserted into the template 
        /// </summary>
		public String TagValue { get; set; }
	} 
}