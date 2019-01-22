using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdatedResendItem
	{
        /// <summary>
        /// The RMA row identifier for this line 
        /// </summary>
		public Int32 RMARowId;

        /// <summary>
        /// If set to true, will remove the line from the booking 
        /// </summary>
		public Boolean RemoveFromBooking;

		public Int32 ResendQuantity;

		public Guid DespatchLocationId;

		public Decimal AdditionalCost;

		public Guid OrderItemRowId;

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
	} 
}