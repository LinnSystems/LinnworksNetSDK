var Settings =
{
	// http://apidoc.linnworks.net/#/Settings-AddSetting
	AddSetting: function(category,setting,value,userSpecific,token, server)
	{
		return Factory.GetResponse("Settings/AddSetting", token, server, "category=" + category + "&setting=" + setting + "&value=" + value + "&userSpecific=" + userSpecific +"");
	},
	// http://apidoc.linnworks.net/#/Settings-DeleteSetting
	DeleteSetting: function(category,setting,userSpecific,token, server)
	{
		return Factory.GetResponse("Settings/DeleteSetting", token, server, "category=" + category + "&setting=" + setting + "&userSpecific=" + userSpecific +"");
	},
	// http://apidoc.linnworks.net/#/Settings-GetSettings
	GetSettings: function(categories,token, server)
	{
		return Factory.GetResponse("Settings/GetSettings", token, server, "categories=" + JSON.stringify(categories) +"");
	},
	// http://apidoc.linnworks.net/#/Settings-IsCustomerAuthorized
	IsCustomerAuthorized: function(module,token, server)
	{
		return Factory.GetResponse("Settings/IsCustomerAuthorized", token, server, "module=" + module +"");
	},
	// http://apidoc.linnworks.net/#/Settings-IsBetaApplied
	IsBetaApplied: function(module,token, server)
	{
		return Factory.GetResponse("Settings/IsBetaApplied", token, server, "module=" + module +"");
	},
	// http://apidoc.linnworks.net/#/Settings-RequestCustomerAccess
	RequestCustomerAccess: function(module,name,telephone,time,token, server)
	{
		return Factory.GetResponse("Settings/RequestCustomerAccess", token, server, "module=" + module + "&name=" + name + "&telephone=" + telephone + "&time=" + JSON.stringify(time) +"");
	},
	// http://apidoc.linnworks.net/#/Settings-GetMeasures
	GetMeasures: function(token, server)
	{
		return Factory.GetResponse("Settings/GetMeasures", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Settings-GetXmlSetting
	GetXmlSetting: function(name,category,token, server)
	{
		return Factory.GetResponse("Settings/GetXmlSetting", token, server, "name=" + name + "&category=" + category +"");
	},
};
