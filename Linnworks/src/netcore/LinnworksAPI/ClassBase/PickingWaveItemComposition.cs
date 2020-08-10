using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickingWaveItemComposition
	{
        /// <summary>
        /// Stock item id 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// Composite parent order item row id 
        /// </summary>
		public Guid OrderItemRowId { get; set; }

        /// <summary>
        /// Quantity of composite. 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Child row relationships to parent 
        /// </summary>
		public List<PickingWaveItemComposition> Children { get; set; }
	} 
}