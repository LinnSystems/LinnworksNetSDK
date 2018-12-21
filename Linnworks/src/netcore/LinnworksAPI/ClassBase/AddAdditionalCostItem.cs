using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Add additional cost item Id 
    /// </summary>
    public class AddAdditionalCostItem
	{
        /// <summary>
        /// Each item in the request can have unique Id supplied (uniqueidentifier) this Id will be returned to you in the response so you can match request item with the response 
        /// </summary>
		public Guid Id;

		public Int32 AdditionalCostTypeId;

		public String Reference;

		public Decimal SubTotalLineCost;

		public Decimal TaxRate;

		public String Currency;

		public Decimal ConversionRate;

		public Boolean AllocationLocked;

		public Boolean Print;

		public AllocationMethods AllocationMethod;
	} 
}