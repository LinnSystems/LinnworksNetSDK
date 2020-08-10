using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EmailTemplateType
	{
		public String AttachmentHelpText { get; set; }

		public String EmailType_Dispatch { get; set; }

		public String Type { get; set; }

		public String Name { get; set; }

		public Boolean IsAdhoc { get; set; }

		public Boolean IsDesignerVisible { get; set; }

		public EmailParsableCreator ParsableCreator { get; set; }

		public List<TemplateTag> Tags { get; set; }

		public Boolean AttachPDFAvailable { get; set; }

		public String PrintingTemplateType { get; set; }

		public List<EmailTemplateType> EmailTemplateTypes { get; set; }

		public String AttachedFileName { get; set; }
	} 
}