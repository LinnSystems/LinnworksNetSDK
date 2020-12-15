using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class MacroController : BaseController, IMacroController
    {
        public MacroController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Get a list of all macros and their related applications as installed on the users system 
        /// </summary>
        /// <param name="request">Empty request in place for later extension</param>
        /// <returns>List of macros</returns>
        public GetInstalledMacrosResponse GetInstalledMacros(GetInstalledMacroRequest request)
		{
			var response = GetResponse("Macro/GetInstalledMacros", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetInstalledMacrosResponse>(response);
		}

		/// <summary>
        /// Get all the macro configurations for the user account 
        /// </summary>
        public List<MacroRegister> GetMacroConfigurations(GetMacroConfigurationsRequest request)
		{
			var response = GetResponse("Macro/GetMacroConfigurations", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<List<MacroRegister>>(response);
		} 
    }
}