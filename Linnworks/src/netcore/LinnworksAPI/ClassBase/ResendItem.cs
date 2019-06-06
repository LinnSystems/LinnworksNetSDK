using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ResendItem
	{
        /// <summary>
        /// The quantity of the selected item to resend 
        /// </summary>
		public Int32 ResendQuantity;

        /// <summary>
        /// The identifier for the location to create the resend order in. This is where the item will have its stock deducted from 
        /// </summary>
		public Guid DespatchLocationId;

        /// <summary>
        /// This field denotes the additional cost that will be incurred to the customer for this resend 
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