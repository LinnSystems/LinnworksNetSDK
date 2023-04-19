using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetStockItemsLocationRequest : LinnObject
	{
		public List<StockLocationStockItemId> StockItemLocations { get; set; }

		public String AuthToken { get; set; }

		public String AccountId { get; set; }

		public String VendorFriendlyName { get; set; }

		public String Vendor { get; set; }
	} 
}