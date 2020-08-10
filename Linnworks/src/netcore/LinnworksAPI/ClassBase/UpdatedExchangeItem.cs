using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdatedExchangeItem
	{
        /// <summary>
        /// The RMA row identifier for this line 
        /// </summary>
		public Int32 RMARowId { get; set; }

        /// <summary>
        /// If set to true, will remove the line from the booking 
        /// </summary>
		public Boolean RemoveFromBooking { get; set; }

		public Guid ExchangeStockItemId { get; set; }

		public String ExchangeSKU { get; set; }

		public String ExchangeTitle { get; set; }

		public Int32 ExchangeQuantity { get; set; }

		public Guid DespatchLocationId { get; set; }

		public Decimal AdditionalCost { get; set; }

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