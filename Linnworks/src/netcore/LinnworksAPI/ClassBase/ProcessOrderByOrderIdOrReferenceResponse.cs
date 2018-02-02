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
		public OrderProcessedState ProcessedState;

        /// <summary>
        /// A message - Provided if there have been errors 
        /// </summary>
		public String Message;

        /// <summary>
        /// A response object used if further action is required 
        /// </summary>
		public Object Response;

        /// <summary>
        /// The ID of the order - Guid empty if not found 
        /// </summary>
		public Guid OrderId;

        /// <summary>
        /// Used when an order has been processed 
        /// </summary>
		public OrderSummary OrderSummary;

        /// <summary>
        /// The items that need to be scanned - If any 
        /// </summary>
		public List<OrderItem> Items;

        /// <summary>
        /// The batched items 
        /// </summary>
		public List<StockItemBatch> BatchInformation;
	} 
}