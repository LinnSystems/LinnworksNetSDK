using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemTypeInfo
	{
		public String SKU;

		public Int32 StockItemIntId;

		public Guid StockItemId;

		public Boolean IsVariationGroup;

		public Boolean IsCompositeParent;

		public Boolean IsArchived;

		public Byte InventoryTrackingType;
	} 
}