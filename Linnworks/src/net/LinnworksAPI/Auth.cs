using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
namespace LinnworksAPI
{public static class AuthMethods 
{ public static ApplicationProfileResponse GetApplicationProfileBySecretKey(Guid applicationId,Guid applicationSecret,Guid userId)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<ApplicationProfileResponse>(Factory.GetResponse("Auth/GetApplicationProfileBySecretKey", "applicationId=" + applicationId + "&applicationSecret=" + applicationSecret + "&userId=" + userId + "", "", ""), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static BaseSession AuthorizeByApplication(Guid applicationId,Guid applicationSecret,Guid token)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<BaseSession>(Factory.GetResponse("Auth/AuthorizeByApplication", "applicationId=" + applicationId + "&applicationSecret=" + applicationSecret + "&token=" + token + "", "", ""), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static BaseSession GetSession(string token)
{
    return Newtonsoft.Json.JsonConvert.DeserializeObject<BaseSession>(Factory.GetResponse("Auth/GetSession", "token=" + token, "", ""), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }); 
}

public static DateTime GetServerUTCTime()
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<DateTime>(Factory.GetResponse("Auth/GetServerUTCTime", "", "", ""), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
} 
}
}