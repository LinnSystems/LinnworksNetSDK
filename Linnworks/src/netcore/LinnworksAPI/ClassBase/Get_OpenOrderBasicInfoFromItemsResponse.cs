using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Get_OpenOrderBasicInfoFromItemsResponse : LinnObject
	{
		public List<OpenOrderBasicInfo> OpenOrders { get; set; }
	} 
}