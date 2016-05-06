using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
namespace LinnworksAPI
{public static class CustomerMethods 
{ public static void CreateNewCustomer(CustomerAddress customerDetails,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Customer/CreateNewCustomer", "customerDetails=" + Newtonsoft.Json.JsonConvert.SerializeObject(customerDetails) + "", ApiToken, ApiServer); 
} 
}
}