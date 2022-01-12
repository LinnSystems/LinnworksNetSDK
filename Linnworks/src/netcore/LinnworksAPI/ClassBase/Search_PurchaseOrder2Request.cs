using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Search Purchase order class 
    /// </summary>
    public class Search_PurchaseOrder2Request
	{
        /// <summary>
        /// Purchase order date range from (optional) 
        /// </summary>
		public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Purchase order date range to (optional) 
        /// </summary>
		public DateTime? DateTo { get; set; }

        /// <summary>
        /// Purchase order status: PENDING - purchase order can be changed, not yet affecting stock levels
        /// OPEN - purchase order is created and stock levels Due are reflected
        /// PARTIAL - partially delivered 
        /// DELIVERED - fully delivered 
        /// </summary>
		public PurchaseOrderStatus? Status { get; set; }

        /// <summary>
        /// Specifies search value to filter with result set 
        /// </summary>
		public String SearchValue { get; set; }

        /// <summary>
        /// Specifies search value type for search value 
        /// </summary>
		public PurchaseOrderSearchType SearchType { get; set; }

        /// <summary>
        /// Number of records returned, sorted by Purchase Order Date 
        /// </summary>
		public Int32 EntriesPerPage { get; set; }

        /// <summary>
        /// Page Number 
        /// </summary>
		public Int32 PageNumber { get; set; }

        /// <summary>
        /// Current Location 
        /// </summary>
		public List<Guid> Location { get; set; }

        /// <summary>
        /// Current Supplier 
        /// </summary>
		public List<Guid> Supplier { get; set; }
	} 
}