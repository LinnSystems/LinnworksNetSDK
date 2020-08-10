using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemChannelSkuResponse
	{
		public Guid StockItemId;

		public List<StockItemChannelSKU> ChannelSkus;
	} 
}