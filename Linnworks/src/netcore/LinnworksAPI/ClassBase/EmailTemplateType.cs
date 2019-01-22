using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EmailTemplateType
	{
		public String AttachmentHelpText;

		public String EmailType_Dispatch;

		public String Type;

		public String Name;

		public Boolean IsAdhoc;

		public Boolean IsDesignerVisible;

		public EmailParsableCreator ParsableCreator;

		public List<TemplateTag> Tags;

		public Boolean AttachPDFAvailable;

		public String PrintingTemplateType;

		public List<EmailTemplateType> EmailTemplateTypes;

		public String AttachedFileName;
	} 
}