var Account =
{
	// http://apidoc.linnworks.net/#/Account-Account_GenerateAnywhereToken
	Account_GenerateAnywhereToken: function(token, server)
	{
		return Factory.GetResponse("Account/Account_GenerateAnywhereToken", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Account-Test
	Test: function(token, server)
	{
		return Factory.GetResponse("Account/Test", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Account-Helpers_Country_List
	Helpers_Country_List: function(token, server)
	{
		return Factory.GetResponse("Account/Helpers_Country_List", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Account-Helpers_Vatin_GetCountryVatInfo
	Helpers_Vatin_GetCountryVatInfo: function(country,token, server)
	{
		return Factory.GetResponse("Account/Helpers_Vatin_GetCountryVatInfo", token, server, "country=" + country +"");
	},
	// http://apidoc.linnworks.net/#/Account-AccountDetails_Get
	AccountDetails_Get: function(token, server)
	{
		return Factory.GetResponse("Account/AccountDetails_Get", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Account-AccountDetails_Update_ContactDetails
	AccountDetails_Update_ContactDetails: function(details,token, server)
	{
		return Factory.GetResponse("Account/AccountDetails_Update_ContactDetails", token, server, "details=" + JSON.stringify(details) +"");
	},
	// http://apidoc.linnworks.net/#/Account-AccountDetails_Update_ForumName
	AccountDetails_Update_ForumName: function(forumName,token, server)
	{
		return Factory.GetResponse("Account/AccountDetails_Update_ForumName", token, server, "forumName=" + forumName +"");
	},
};
