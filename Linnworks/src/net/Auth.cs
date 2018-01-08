using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{
	public static class AuthMethods 
	{ 
		private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ"};
 		public static ApplicationProfileResponse GetApplicationProfileBySecretKey(Guid applicationId,Guid applicationSecret,Guid userId)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ApplicationProfileResponse>(Factory.GetResponse("Auth/GetApplicationProfileBySecretKey", "applicationId=" + applicationId + "&applicationSecret=" + applicationSecret + "&userId=" + userId + "", Guid.Empty, ""), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static BaseSession AuthorizeByApplication(Guid applicationId,Guid applicationSecret,Guid token)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<BaseSession>(Factory.GetResponse("Auth/AuthorizeByApplication", "applicationId=" + applicationId + "&applicationSecret=" + applicationSecret + "&token=" + token + "", Guid.Empty, ""), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static DateTime GetServerUTCTime()		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<DateTime>(Factory.GetResponse("Auth/GetServerUTCTime", "", Guid.Empty, ""), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		} 
	}
}