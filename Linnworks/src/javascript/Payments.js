var Payments =
{
	// http://apidoc.linnworks.net/#/Payments-GetCheckoutInformation
	GetCheckoutInformation: function(Request,token, server)
	{
		return Factory.GetResponse("Payments/GetCheckoutInformation", token, server, "Request=" + JSON.stringify(Request) +"");
	},
	// http://apidoc.linnworks.net/#/Payments-CompleteCheckoutPayment
	CompleteCheckoutPayment: function(Request,token, server)
	{
		return Factory.GetResponse("Payments/CompleteCheckoutPayment", token, server, "Request=" + JSON.stringify(Request) +"");
	},
};
