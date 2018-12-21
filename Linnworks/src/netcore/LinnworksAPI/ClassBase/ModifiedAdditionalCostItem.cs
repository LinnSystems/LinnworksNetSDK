using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ModifiedAdditionalCostItem
	{
		public Guid Id;

		public Int32 PurchaseAdditionalCostItemId;

		public Int32 AdditionalCostTypeId;

		public String Reference;

		public Decimal SubTotalLineCost;

		public Decimal TaxRate;

		public Decimal Tax;

		public String Currency;

		public Decimal ConversionRate;

		public Decimal TotalLineCost;

		public List<PurchaseOrderAdditionalCostAllocation> CostAllocation;

		public Boolean AllocationLocked;

		public String AdditionalCostTypeName;

		public Boolean AdditionalCostTypeIsShippingType;

		public Boolean AdditionalCostTypeIsPartialAllocation;

		public Boolean Print;

		public AllocationMethods AllocationMethod;
	} 
}