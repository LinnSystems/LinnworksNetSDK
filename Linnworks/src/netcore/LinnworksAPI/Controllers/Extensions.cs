using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Web.Http;
using System.Net.Http;

namespace LinnworksAPI
{
    public class ExtensionsController : BaseController, IExtensionsController
    {
        public ExtensionsController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        public IHttpActionResult DeleteSetting(BaseSettingRequest request)
		{
			var response = GetResponse("Extensions/DeleteSetting", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<IHttpActionResult>(response);
		}

		public HttpResponseMessage GetSetting(BaseSettingRequest request)
		{
			var response = GetResponse("Extensions/GetSetting", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<HttpResponseMessage>(response);
		}

		public GetSettingKeysResponse GetSettingKeys(BaseSettingsRequest request)
		{
			var response = GetResponse("Extensions/GetSettingKeys", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetSettingKeysResponse>(response);
		}

		public GetSettingsResponse GetSettings(BaseSettingsRequest request)
		{
			var response = GetResponse("Extensions/GetSettings", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetSettingsResponse>(response);
		}

		public IHttpActionResult SetSetting(SetSettingRequest request)
		{
			var response = GetResponse("Extensions/SetSetting", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<IHttpActionResult>(response);
		} 
    }
}