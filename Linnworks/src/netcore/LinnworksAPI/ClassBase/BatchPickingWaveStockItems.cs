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
		public Int32 PickingWaveItemsRowId;

        /// <summary>
        /// Pickwave Id 
        /// </summary>
		public Int32 PickingWaveId;

        /// <summary>
        /// User name to whom the pickwave was/is allocated. If unallocated this will be null 
        /// </summary>
		public String UserName;

        /// <summary>
        /// Total Quantity to pick 
        /// </summary>
		public Int32 ToPickQuantity;

        /// <summary>
        /// Picked quantity 
        /// </summary>
		public Int32 PickedQuantity;

        /// <summary>
        /// Stock Item Id 
        /// </summary>
		public Guid StockItemId;

        /// <summary>
        /// Order Id 
        /// </summary>
		public Int32 OrderId;

        /// <summary>
        /// User Id to whom the pickwave was/is allocated. If unallocated this will be null 
        /// </summary>
		public Int32? UserId;
	} 
}