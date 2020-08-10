using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BatchPickingWaveStockItems
	{
        /// <summary>
        /// Pickwave Row Id 
        /// </summary>
		public Int32 PickingWaveItemsRowId { get; set; }

        /// <summary>
        /// Pickwave Id 
        /// </summary>
		public Int32 PickingWaveId { get; set; }

        /// <summary>
        /// User name to whom the pickwave was/is allocated. If unallocated this will be null 
        /// </summary>
		public String UserName { get; set; }

        /// <summary>
        /// Total Quantity to pick 
        /// </summary>
		public Int32 ToPickQuantity { get; set; }

        /// <summary>
        /// Picked quantity 
        /// </summary>
		public Int32 PickedQuantity { get; set; }

        /// <summary>
        /// Stock Item Id 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// Order Id 
        /// </summary>
		public Int32 OrderId { get; set; }

        /// <summary>
        /// User Id to whom the pickwave was/is allocated. If unallocated this will be null 
        /// </summary>
		public Int32? UserId { get; set; }
	} 
}