using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ExchangeItem
	{
        /// <summary>
        /// The stock item ID for the item that will replace the returned item 
        /// </summary>
		public Guid ExchangeStockItemId;

        /// <summary>
        /// Identifies the SKU of the item that will replace the returned item 
        /// </summary>
		public String ExchangeSKU;

        /// <summary>
        /// Identifies the title of the item that will replace the returned item 
        /// </summary>
		public String ExchangeTitle;

        /// <summary>
        /// The number of this item to send as part of the exchange 
        /// </summary>
		public Int32 ExchangeQuantity;

        /// <summary>
        /// The identifier for the location to create the exchange order in. This is where the item will have its stock deducted from 
        /// </summary>
		public Guid DespatchLocationId;

        /// <summary>
        /// This field denotes the additional cost that will be incurred to the customer for this exchange 
        /// </summary>
		public Decimal AdditionalCost;

		public Guid OrderItemRowId;

		public String ReturnItemSKU;

		public String ReturnItemTitle;

		public Int32? BatchInventoryId;

		public Guid ReturnLocation;

		public Int32 ReturnQuantity;

		public Decimal RefundAmount;

		public Guid? RefundRowId;

		public Int32 ScrapQuantity;

		public String ReasonCategory;

		public Boolean IsFreeText;

		public String Reason;

		public String ReasonTag;

		public String SubReasonTag;

		public String BinrackOverride;
	} 
}