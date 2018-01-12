var PostalServices =
{
	// http://apidoc.linnworks.net/#/PostalServices-CreatePostalService
	CreatePostalService: function(PostalServiceDetails,token, server)
	{
		return Factory.GetResponse("PostalServices/CreatePostalService", token, server, "PostalServiceDetails=" + JSON.stringify(PostalServiceDetails) +"");
	},
	// http://apidoc.linnworks.net/#/PostalServices-DeletePostalService
	DeletePostalService: function(idToDelete,token, server)
	{
		return Factory.GetResponse("PostalServices/DeletePostalService", token, server, "idToDelete=" + idToDelete +"");
	},
	// http://apidoc.linnworks.net/#/PostalServices-GetChannelLinks
	GetChannelLinks: function(postalServiceId,token, server)
	{
		return Factory.GetResponse("PostalServices/GetChannelLinks", token, server, "postalServiceId=" + postalServiceId +"");
	},
	// http://apidoc.linnworks.net/#/PostalServices-GetPostalServices
	GetPostalServices: function(token, server)
	{
		return Factory.GetResponse("PostalServices/GetPostalServices", token, server, "");
	},
	// http://apidoc.linnworks.net/#/PostalServices-UpdatePostalService
	UpdatePostalService: function(PostalServiceDetails,token, server)
	{
		return Factory.GetResponse("PostalServices/UpdatePostalService", token, server, "PostalServiceDetails=" + JSON.stringify(PostalServiceDetails) +"");
	},
};
