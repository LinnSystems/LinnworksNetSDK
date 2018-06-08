using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DataPurgeObfuscateOrderSetRequest
	{
		public List<Guid> pkOrderIds;

		public String AccessToken;

		public String UserName;

		public String Password;
	} 
}