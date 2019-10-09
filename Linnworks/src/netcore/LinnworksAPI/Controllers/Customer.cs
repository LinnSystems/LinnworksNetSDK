using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class CustomerController : BaseController, ICustomerController
    {
        public CustomerController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Creates a new customer. 
        /// </summary>
        /// <param name="customerDetails">Includes all the customer details</param>
        public void CreateNewCustomer(CustomerAddress customerDetails)
		{
			GetResponse("Customer/CreateNewCustomer", "customerDetails=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(customerDetails)) + "");
		} 
    }
}