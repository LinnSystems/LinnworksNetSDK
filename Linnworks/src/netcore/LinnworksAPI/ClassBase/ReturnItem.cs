using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ReturnItem
	{
		public Guid OrderItemRowId { get; set; }

		public String ReturnItemSKU { get; set; }

		public String ReturnItemTitle { get; set; }

		public Int32? BatchInventoryId { get; set; }

		public Guid ReturnLocation { get; set; }

		public Int32 ReturnQuantity { get; set; }

		public Decimal RefundAmount { get; set; }

		public Guid? RefundRowId { get; set; }

		public Int32 ScrapQuantity { get; set; }

		public String ReasonCategory { get; set; }

		public Boolean IsFreeText { get; set; }

		public String Reason { get; set; }

		public String ReasonTag { get; set; }

		public String SubReasonTag { get; set; }

		public String BinrackOverride { get; set; }
	} 
}