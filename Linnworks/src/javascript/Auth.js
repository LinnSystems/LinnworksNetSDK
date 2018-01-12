var Auth =
{
	// http://apidoc.linnworks.net/#/Auth-AuthorizeByApplication
	AuthorizeByApplication: function(applicationId,applicationSecret,token)
	{
		return Factory.GetResponse("Auth/AuthorizeByApplication", "", "", "applicationId=" + applicationId + "&applicationSecret=" + applicationSecret + "&token=" + token +"");
	},
	// http://apidoc.linnworks.net/#/Auth-GetApplicationProfileBySecretKey
	GetApplicationProfileBySecretKey: function(applicationId,applicationSecret,userId)
	{
		return Factory.GetResponse("Auth/GetApplicationProfileBySecretKey", "", "", "applicationId=" + applicationId + "&applicationSecret=" + applicationSecret + "&userId=" + userId +"");
	},
	// http://apidoc.linnworks.net/#/Auth-GetServerUTCTime
	GetServerUTCTime: function()
	{
		return Factory.GetResponse("Auth/GetServerUTCTime", "", "", "");
	},
};
