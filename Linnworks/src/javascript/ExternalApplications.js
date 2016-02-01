var ExternalApplications =
{
	// http://apidoc.linnworks.net/#/ExternalApplications-RevokeToken
	RevokeToken: function(token,token, server)
	{
		return Factory.GetResponse("ExternalApplications/RevokeToken", token, server, "token=" + token +"");
	},
	// http://apidoc.linnworks.net/#/ExternalApplications-UninstallApplication
	UninstallApplication: function(InstallationId,token, server)
	{
		return Factory.GetResponse("ExternalApplications/UninstallApplication", token, server, "InstallationId=" + InstallationId +"");
	},
	// http://apidoc.linnworks.net/#/ExternalApplications-LeaveReview
	LeaveReview: function(applicationId,rating,comment,token, server)
	{
		return Factory.GetResponse("ExternalApplications/LeaveReview", token, server, "applicationId=" + applicationId + "&rating=" + rating + "&comment=" + comment +"");
	},
	// http://apidoc.linnworks.net/#/ExternalApplications-GetTemporaryToken
	GetTemporaryToken: function(ApplicationInstallationId)
	{
		return Factory.GetResponse("ExternalApplications/GetTemporaryToken", "", "", "ApplicationInstallationId=" + ApplicationInstallationId +"");
	},
	// http://apidoc.linnworks.net/#/ExternalApplications-GetApplication
	GetApplication: function(applicationId,loadReviews,token, server)
	{
		return Factory.GetResponse("ExternalApplications/GetApplication", token, server, "applicationId=" + applicationId + "&loadReviews=" + loadReviews +"");
	},
	// http://apidoc.linnworks.net/#/ExternalApplications-SearchApplications
	SearchApplications: function(searchString,count,token, server)
	{
		return Factory.GetResponse("ExternalApplications/SearchApplications", token, server, "searchString=" + searchString + "&count=" + count +"");
	},
	// http://apidoc.linnworks.net/#/ExternalApplications-GetTokens
	GetTokens: function(token, server)
	{
		return Factory.GetResponse("ExternalApplications/GetTokens", token, server, "");
	},
	// http://apidoc.linnworks.net/#/ExternalApplications-GetInstalled
	GetInstalled: function(token, server)
	{
		return Factory.GetResponse("ExternalApplications/GetInstalled", token, server, "");
	},
	// http://apidoc.linnworks.net/#/ExternalApplications-DownloadLinnworksDesktopClient
	DownloadLinnworksDesktopClient: function(token, server)
	{
		return Factory.GetResponse("ExternalApplications/DownloadLinnworksDesktopClient", token, server, "");
	},
};
