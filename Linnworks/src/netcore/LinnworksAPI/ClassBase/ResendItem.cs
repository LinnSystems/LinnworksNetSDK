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
		public Int32 ResendQuantity { get; set; }

        /// <summary>
        /// The identifier for the location to create the resend order in. This is where the item will have its stock deducted from 
        /// </summary>
		public Guid DespatchLocationId { get; set; }

        /// <summary>
        /// This field denotes the additional cost that will be incurred to the customer for this resend 
        /// </summary>
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