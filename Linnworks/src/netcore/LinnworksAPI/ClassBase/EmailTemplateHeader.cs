using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Represent a simple version of EmailTemplate, with genering information 
    /// </summary>
    public class EmailTemplateHeader
	{
        /// <summary>
        /// Row Id 
        /// </summary>
		public Int32 pkEmailTemplateRowId { get; set; }

        /// <summary>
        /// Template friendly name 
        /// </summary>
		public String Name { get; set; }

        /// <summary>
        /// Template type 
        /// </summary>
		public String TemplateType { get; set; }

        /// <summary>
        /// Indicate if the template has conditions defined 
        /// </summary>
		public Boolean IsConditions { get; set; }

        /// <summary>
        /// Template condition defined 
        /// </summary>
		public String Condition { get; set; }

        /// <summary>
        /// Indicate if the template is enabled or not 
        /// </summary>
		public Boolean Enabled { get; set; }

        /// <summary>
        /// Row Id of the email account used to send the email 
        /// </summary>
		public Int32 fkEmailAccountRowId { get; set; }

        /// <summary>
        /// Name of the email account used to send the email 
        /// </summary>
		public String AccountName { get; set; }

        /// <summary>
        /// Indicate if this template has attachments enabled 
        /// </summary>
		public Boolean AttachPDF { get; set; }

        /// <summary>
        /// Indicates if the email type is adhoc 
        /// </summary>
		public Boolean IsAdhoc { get; set; }

        /// <summary>
        /// Indicates whether the email is a HTML email 
        /// </summary>
		public Boolean HTML { get; set; }
	} 
}