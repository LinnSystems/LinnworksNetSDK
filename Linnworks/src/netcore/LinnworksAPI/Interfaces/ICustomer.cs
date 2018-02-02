using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface ICustomerController
	{
		void CreateNewCustomer(CustomerAddress customerDetails);
	} 
}