var Locations =
{
	// http://apidoc.linnworks.net/#/Locations-AddLocation
	AddLocation: function(location,token, server)
	{
		return Factory.GetResponse("Locations/AddLocation", token, server, "location=" + JSON.stringify(location) +"");
	},
	// http://apidoc.linnworks.net/#/Locations-DeleteLocation
	DeleteLocation: function(pkStockLocationId,token, server)
	{
		return Factory.GetResponse("Locations/DeleteLocation", token, server, "pkStockLocationId=" + pkStockLocationId +"");
	},
	// http://apidoc.linnworks.net/#/Locations-GetLocation
	GetLocation: function(pkStockLocationId,token, server)
	{
		return Factory.GetResponse("Locations/GetLocation", token, server, "pkStockLocationId=" + pkStockLocationId +"");
	},
	// http://apidoc.linnworks.net/#/Locations-UpdateLocation
	UpdateLocation: function(location,token, server)
	{
		return Factory.GetResponse("Locations/UpdateLocation", token, server, "location=" + JSON.stringify(location) +"");
	},
};
