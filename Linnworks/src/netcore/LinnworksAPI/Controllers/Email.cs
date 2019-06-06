using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class EmailController : BaseController, IEmailController
    {
        public EmailController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Generate a custom email 
        /// </summary>
        /// <param name="request">Custom email generation request body</param>
        public GenerateAdhocEmailResponse GenerateAdhocEmail(GenerateAdhocEmailRequest request)
		{
			var response = GetResponse("Email/GenerateAdhocEmail", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GenerateAdhocEmailResponse>(response);
		}

		/// <summary>
        /// Generate a custom email 
        /// </summary>
        /// <param name="request"></param>
        public GenerateFreeTextEmailResponse GenerateFreeTextEmail(GenerateFreeTextEmailRequest request)
		{
			var response = GetResponse("Email/GenerateFreeTextEmail", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GenerateFreeTextEmailResponse>(response);
		}

		/// <summary>
        /// Get the full data of a specific email template 
        /// </summary>
        /// <param name="pkEmailTemplateRowId">Id of the email template to retrieve</param>
        /// <returns>Email template object with full data</returns>
        public EmailTemplate GetEmailTemplate(Int32 pkEmailTemplateRowId)
		{
			var response = GetResponse("Email/GetEmailTemplate", "pkEmailTemplateRowId=" + pkEmailTemplateRowId + "");
            return JsonFormatter.ConvertFromJson<EmailTemplate>(response);
		}

		/// <summary>
        /// Get the whole list of email header templates 
        /// </summary>
        /// <returns>List of email template headers</returns>
        public List<EmailTemplateHeader> GetEmailTemplates()
		{
			var response = GetResponse("Email/GetEmailTemplates", "");
            return JsonFormatter.ConvertFromJson<List<EmailTemplateHeader>>(response);
		} 
    }
}