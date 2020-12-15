using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Web.Http;
using System.Net.Http;

namespace LinnworksAPI
{ 
    public interface IExtensionsController
	{
		IHttpActionResult DeleteSetting(BaseSettingRequest request);
		HttpResponseMessage GetSetting(BaseSettingRequest request);
		GetSettingKeysResponse GetSettingKeys(BaseSettingsRequest request);
		GetSettingsResponse GetSettings(BaseSettingsRequest request);
		IHttpActionResult SetSetting(SetSettingRequest request);
	} 
}