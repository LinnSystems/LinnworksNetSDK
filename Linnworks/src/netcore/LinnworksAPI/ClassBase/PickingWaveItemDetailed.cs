using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickingWaveItemDetailed
	{
        /// <summary>
        /// Sort order 
        /// </summary>
		public Int32 SortOrder { get; set; }

        /// <summary>
        /// Quantity to pick 
        /// </summary>
		public Int32 ToPickQuantity { get; set; }

        /// <summary>
        /// ToT Id 
        /// </summary>
		public Int32? TOTId { get; set; }

        /// <summary>
        /// Tray tag 
        /// </summary>
		public String TrayTag { get; set; }

        /// <summary>
        /// Picking tag 
        /// </summary>
		public String PickingTag { get; set; }

        /// <summary>
        /// Pickwave item row id 
        /// </summary>
		public Int32 PickingWaveItemsRowId { get; set; }

        /// <summary>
        /// Pickwave id 
        /// </summary>
		public Int32 PickingWaveId { get; set; }

        /// <summary>
        /// Quatity picked 
        /// </summary>
		public Int32 PickedQuantity { get; set; }

        /// <summary>
        /// Pickwave item state 
        /// </summary>
		public PickingWaveItemState ItemState { get; set; }

        /// <summary>
        /// Collection of pickwave item totes. 
        /// </summary>
		public List<PickingWaveItemTote> Totes { get; set; }

		public Int32? BatchInventoryId { get; set; }

		public Int32 OrderId { get; set; }

		public Guid OrderItemRowId { get; set; }

		public Guid StockItemId { get; set; }
	} 
}