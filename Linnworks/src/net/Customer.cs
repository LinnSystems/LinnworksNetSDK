using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{
	public static class CustomerMethods 
	{ 
		private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ"};
 		public static void CreateNewCustomer(CustomerAddress customerDetails,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Customer/CreateNewCustomer", "customerDetails=" + Newtonsoft.Json.JsonConvert.SerializeObject(customerDetails, serializerSettings) + "", ApiToken, ApiServer); 
		} 
	}
}