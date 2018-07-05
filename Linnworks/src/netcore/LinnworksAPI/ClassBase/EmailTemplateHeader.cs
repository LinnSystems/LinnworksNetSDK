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
		public Int32 pkEmailTemplateRowId;

        /// <summary>
        /// Template friendly name 
        /// </summary>
		public String Name;

        /// <summary>
        /// Template type 
        /// </summary>
		public String TemplateType;

        /// <summary>
        /// Indicate if the template has conditions defined 
        /// </summary>
		public Boolean IsConditions;

        /// <summary>
        /// Template condition defined 
        /// </summary>
		public String Condition;

        /// <summary>
        /// Indicate if the template is enabled or not 
        /// </summary>
		public Boolean Enabled;

        /// <summary>
        /// Row Id of the email account used to send the email 
        /// </summary>
		public Int32 fkEmailAccountRowId;

        /// <summary>
        /// Name of the email account used to send the email 
        /// </summary>
		public String AccountName;

        /// <summary>
        /// Indicate if this template has attachments enabled 
        /// </summary>
		public Boolean AttachPDF;

        /// <summary>
        /// Indicates if the email type is adhoc 
        /// </summary>
		public Boolean IsAdhoc;

        /// <summary>
        /// Indicates whether the email is a HTML email 
        /// </summary>
		public Boolean HTML;
	} 
}