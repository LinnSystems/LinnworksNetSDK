var Auth =
{
	// http://apidoc.linnworks.net/#/Auth-GetDebugInformation
	GetDebugInformation: function(key,password)
	{
		return Factory.GetResponse("Auth/GetDebugInformation", "", "", "key=" + key + "&password=" + password +"");
	},
	// http://apidoc.linnworks.net/#/Auth-MultiLogin
	MultiLogin: function(userName,password)
	{
		return Factory.GetResponse("Auth/MultiLogin", "", "", "userName=" + userName + "&password=" + password +"");
	},
	// http://apidoc.linnworks.net/#/Auth-Authorize
	Authorize: function(userName,password,userId)
	{
		return Factory.GetResponse("Auth/Authorize", "", "", "userName=" + userName + "&password=" + password + "&userId=" + userId +"");
	},
	// http://apidoc.linnworks.net/#/Auth-ResetPassword
	ResetPassword: function(userName,resetToken,newPassword,confirmNewPassword)
	{
		return Factory.GetResponse("Auth/ResetPassword", "", "", "userName=" + userName + "&resetToken=" + resetToken + "&newPassword=" + newPassword + "&confirmNewPassword=" + confirmNewPassword +"");
	},
	// http://apidoc.linnworks.net/#/Auth-ResetPasswordRequest
	ResetPasswordRequest: function(userName)
	{
		return Factory.GetResponse("Auth/ResetPasswordRequest", "", "", "userName=" + userName +"");
	},
	// http://apidoc.linnworks.net/#/Auth-AuthorizeByApplication
	AuthorizeByApplication: function(applicationId,applicationSecret,token)
	{
		return Factory.GetResponse("Auth/AuthorizeByApplication", "", "", "applicationId=" + applicationId + "&applicationSecret=" + applicationSecret + "&token=" + token +"");
	},
	// http://apidoc.linnworks.net/#/Auth-GetServerUTCTime
	GetServerUTCTime: function()
	{
		return Factory.GetResponse("Auth/GetServerUTCTime", "", "", "");
	},
};
