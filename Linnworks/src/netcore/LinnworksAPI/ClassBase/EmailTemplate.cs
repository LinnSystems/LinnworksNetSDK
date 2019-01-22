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
		public Int32 pkEmailTemplateRowId;

        /// <summary>
        /// Tempalte friendly name 
        /// </summary>
		public String Name;

        /// <summary>
        /// Template enabled or not 
        /// </summary>
		public Boolean Enabled;

        /// <summary>
        /// Template type. Used to map database field 
        /// </summary>
		public String TemplateType;

        /// <summary>
        /// Template type definition. It's part of this entity because we always need the definition when we get the EmailTemplate entity. To change it, set the "TemplateType" property 
        /// </summary>
		public EmailTemplateType TemplateTypeDefinition;

        /// <summary>
        /// Subject of the email 
        /// </summary>
		public String Subject;

        /// <summary>
        /// Condition to evaluate what template to use 
        /// </summary>
		public String Condition;

        /// <summary>
        /// Preview email before send it 
        /// </summary>
		public Boolean PreviewBeforeGenerating;

        /// <summary>
        /// Indicate if the email is HTML 
        /// </summary>
		public Boolean HTML;

        /// <summary>
        /// Indicate if the email will have an invoice attached 
        /// </summary>
		public Boolean AttachPDF;

        /// <summary>
        /// Email body content 
        /// </summary>
		public String Body;

        /// <summary>
        /// Row Id of the email account used to send the email 
        /// </summary>
		public Int32 fkEmailAccountRowId;

        /// <summary>
        /// Text to be shown to the customer when he want to preview an order 
        /// </summary>
		public String PromptPreviewReferenceNumber;
	} 
}