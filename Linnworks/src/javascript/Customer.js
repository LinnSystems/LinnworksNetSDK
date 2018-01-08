var Customer =
{
	// http://apidoc.linnworks.net/#/Customer-CreateNewCustomer
	CreateNewCustomer: function(customerDetails,token, server)
	{
		return Factory.GetResponse("Customer/CreateNewCustomer", token, server, "customerDetails=" + JSON.stringify(customerDetails) +"");
	},
};
