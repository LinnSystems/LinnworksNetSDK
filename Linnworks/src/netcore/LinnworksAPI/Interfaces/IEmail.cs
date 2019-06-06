using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IEmailController
	{
		GenerateAdhocEmailResponse GenerateAdhocEmail(GenerateAdhocEmailRequest request);
		GenerateFreeTextEmailResponse GenerateFreeTextEmail(GenerateFreeTextEmailRequest request);
		EmailTemplate GetEmailTemplate(Int32 pkEmailTemplateRowId);
		List<EmailTemplateHeader> GetEmailTemplates();
	} 
}