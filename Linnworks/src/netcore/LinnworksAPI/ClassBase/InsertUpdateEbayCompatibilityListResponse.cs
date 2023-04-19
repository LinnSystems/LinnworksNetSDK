using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class InsertUpdateEbayCompatibilityListResponse : LinnObject
	{
		public List<StockItemEbayCompatibility> EbayCompatibilityList { get; set; }
	} 
}