using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ModifiedAdditionalCostItem
	{
		public Guid Id { get; set; }

		public Int32 PurchaseAdditionalCostItemId { get; set; }

		public Int32 AdditionalCostTypeId { get; set; }

		public String Reference { get; set; }

		public Decimal SubTotalLineCost { get; set; }

		public Decimal TaxRate { get; set; }

		public Decimal Tax { get; set; }

		public String Currency { get; set; }

		public Decimal ConversionRate { get; set; }

		public Decimal TotalLineCost { get; set; }

		public List<PurchaseOrderAdditionalCostAllocation> CostAllocation { get; set; }

		public Boolean AllocationLocked { get; set; }

		public String AdditionalCostTypeName { get; set; }

		public Boolean AdditionalCostTypeIsShippingType { get; set; }

		public Boolean AdditionalCostTypeIsPartialAllocation { get; set; }

		public Boolean Print { get; set; }

		public AllocationMethods AllocationMethod { get; set; }
	} 
}