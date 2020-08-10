using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Custom email generation request body 
    /// </summary>
    public class GenerateAdhocEmailRequest
	{
        /// <summary>
        /// List of ids to send template for 
        /// </summary>
		public List<Guid> ids { get; set; }

        /// <summary>
        /// Template id to send 
        /// </summary>
		public Int32 templateId { get; set; }

        /// <summary>
        /// Tags to append to email 
        /// </summary>
		public List<EmailStubCustomTag> tags { get; set; }

        /// <summary>
        /// List of attachments to send with the email 
        /// </summary>
		public List<String> attachments { get; set; }
	} 
}