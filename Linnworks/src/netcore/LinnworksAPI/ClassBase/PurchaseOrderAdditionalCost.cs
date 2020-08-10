using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Purchase order additional cost item 
    /// </summary>
    public class PurchaseOrderAdditionalCost
	{
        /// <summary>
        /// Unique record id 
        /// </summary>
		public Int32 PurchaseAdditionalCostItemId { get; set; }

        /// <summary>
        /// Additional cost type Id 
        /// </summary>
		public Int32 AdditionalCostTypeId { get; set; }

        /// <summary>
        /// Additional cost reference 
        /// </summary>
		public String Reference { get; set; }

        /// <summary>
        /// Line Subtotal (Total less tax) 
        /// </summary>
		public Decimal SubTotalLineCost { get; set; }

        /// <summary>
        /// Tax rate 
        /// </summary>
		public Decimal TaxRate { get; set; }

        /// <summary>
        /// Tax amount 
        /// </summary>
		public Decimal Tax { get; set; }

        /// <summary>
        /// Currency code 
        /// </summary>
		public String Currency { get; set; }

        /// <summary>
        /// Conversion rate from system currency, i.e. system currency rate to additional cost currency. For example if your system currency is GBP and additional cost is in USD the converted value is USD / Rate, example calculation, Rate 1.27, Additional cost total is 100, converted value = 100 USD / 1.27 = 78.98 GBP 
        /// </summary>
		public Decimal ConversionRate { get; set; }

        /// <summary>
        /// Total cost, this is subtotal + tax (in system currency) 
        /// </summary>
		public Decimal TotalLineCost { get; set; }

        /// <summary>
        /// List of cost allocations. The list defines which PO items the additional cost will be attributed to. If the specific value is not entered, it means the cost is equaly distributed
        /// The List is populated as part of Get_PurchaseOrder method 
        /// </summary>
		public List<PurchaseOrderAdditionalCostAllocation> CostAllocation { get; set; }

        /// <summary>
        /// If this flag is set, new items added to PO will not be part of the allocation cost 
        /// </summary>
		public Boolean AllocationLocked { get; set; }

        /// <summary>
        /// Additional cost type name 
        /// </summary>
		public String AdditionalCostTypeName { get; set; }

        /// <summary>
        /// Indicate if the additional cost type is Shipping type 
        /// </summary>
		public Boolean AdditionalCostTypeIsShippingType { get; set; }

        /// <summary>
        /// Indicate if the additional cost type allow partial allocation 
        /// </summary>
		public Boolean AdditionalCostTypeIsPartialAllocation { get; set; }

        /// <summary>
        /// Indicate if the additional cost has to be shown in prints and emails 
        /// </summary>
		public Boolean Print { get; set; }

        /// <summary>
        /// Indicate the method to calculate the allocation %  for each item 
        /// </summary>
		public AllocationMethods AllocationMethod { get; set; }
	} 
}