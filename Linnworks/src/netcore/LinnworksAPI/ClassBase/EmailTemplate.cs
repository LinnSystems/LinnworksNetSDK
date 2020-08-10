using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EmailTemplate
	{
        /// <summary>
        /// Row id 
        /// </summary>
		public Int32 pkEmailTemplateRowId { get; set; }

        /// <summary>
        /// Tempalte friendly name 
        /// </summary>
		public String Name { get; set; }

        /// <summary>
        /// Template enabled or not 
        /// </summary>
		public Boolean Enabled { get; set; }

        /// <summary>
        /// Template type. Used to map database field 
        /// </summary>
		public String TemplateType { get; set; }

        /// <summary>
        /// Template type definition. It's part of this entity because we always need the definition when we get the EmailTemplate entity. To change it, set the "TemplateType" property 
        /// </summary>
		public EmailTemplateType TemplateTypeDefinition { get; set; }

        /// <summary>
        /// Subject of the email 
        /// </summary>
		public String Subject { get; set; }

        /// <summary>
        /// Condition to evaluate what template to use 
        /// </summary>
		public String Condition { get; set; }

        /// <summary>
        /// Preview email before send it 
        /// </summary>
		public Boolean PreviewBeforeGenerating { get; set; }

        /// <summary>
        /// Indicate if the email is HTML 
        /// </summary>
		public Boolean HTML { get; set; }

        /// <summary>
        /// Indicate if the email will have an invoice attached 
        /// </summary>
		public Boolean AttachPDF { get; set; }

        /// <summary>
        /// Email body content 
        /// </summary>
		public String Body { get; set; }

        /// <summary>
        /// Row Id of the email account used to send the email 
        /// </summary>
		public Int32 fkEmailAccountRowId { get; set; }

        /// <summary>
        /// Text to be shown to the customer when he want to preview an order 
        /// </summary>
		public String PromptPreviewReferenceNumber { get; set; }
	} 
}