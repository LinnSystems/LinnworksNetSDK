using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateAdditionalCostItem
	{
        /// <summary>
        /// Additional cost line row id, uniquely identifying each cost line 
        /// </summary>
		public Int32 PurchaseAdditionalCostItemId { get; set; }

        /// <summary>
        /// Each item in the request can have unique Id supplied (uniqueidentifier) this Id will be returned to you in the response so you can match request item with the response 
        /// </summary>
		public Guid Id { get; set; }

		public Int32 AdditionalCostTypeId { get; set; }

		public String Reference { get; set; }

		public Decimal SubTotalLineCost { get; set; }

		public Decimal TaxRate { get; set; }

		public String Currency { get; set; }

		public Decimal ConversionRate { get; set; }

		public Boolean AllocationLocked { get; set; }

		public Boolean Print { get; set; }

		public AllocationMethods AllocationMethod { get; set; }
	} 
}