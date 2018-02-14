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
        /// <param name="request"></param>
        public GenerateFreeTextEmailResponse GenerateFreeTextEmail(GenerateFreeTextEmailRequest request)
		{
			var response = GetResponse("Email/GenerateFreeTextEmail", "request=" + JsonFormatter.ConvertToJson(request) + "");
            return JsonFormatter.ConvertFromJson<GenerateFreeTextEmailResponse>(response);
		} 
    }
}