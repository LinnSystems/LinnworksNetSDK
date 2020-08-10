using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// A response class used when processing an order by order id or reference 
    /// </summary>
    public class ProcessOrderByOrderIdOrReferenceResponse
	{
        /// <summary>
        /// The processed state 
        /// </summary>
		public OrderProcessedState ProcessedState { get; set; }

        /// <summary>
        /// A message - Provided if there have been errors 
        /// </summary>
		public String Message { get; set; }

        /// <summary>
        /// A response object used if further action is required 
        /// </summary>
		public Object Response { get; set; }

        /// <summary>
        /// The ID of the order - Guid empty if not found 
        /// </summary>
		public Guid OrderId { get; set; }

        /// <summary>
        /// Used when an order has been processed 
        /// </summary>
		public OrderSummary OrderSummary { get; set; }

        /// <summary>
        /// The items that need to be scanned - If any 
        /// </summary>
		public List<OrderItem> Items { get; set; }

        /// <summary>
        /// The batched items 
        /// </summary>
		public List<StockItemBatch> BatchInformation { get; set; }
	} 
}