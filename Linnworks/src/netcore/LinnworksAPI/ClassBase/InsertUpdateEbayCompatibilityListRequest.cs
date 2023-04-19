using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class InsertUpdateEbayCompatibilityListRequest : LinnObject
	{
		public List<StockItemEbayCompatibility> EbayCompatibilityList { get; set; }
	} 
}