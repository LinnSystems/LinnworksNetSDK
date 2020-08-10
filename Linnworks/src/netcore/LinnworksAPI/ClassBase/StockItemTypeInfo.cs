using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemTypeInfo
	{
		public String SKU { get; set; }

		public Int32 StockItemIntId { get; set; }

		public Guid StockItemId { get; set; }

		public Boolean IsVariationGroup { get; set; }

		public Boolean IsCompositeParent { get; set; }

		public Boolean IsArchived { get; set; }

		public Byte InventoryTrackingType { get; set; }
	} 
}