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
		public Int32 SortOrder;

        /// <summary>
        /// Quantity to pick 
        /// </summary>
		public Int32 ToPickQuantity;

        /// <summary>
        /// ToT Id 
        /// </summary>
		public Int32? TOTId;

        /// <summary>
        /// Tray tag 
        /// </summary>
		public String TrayTag;

        /// <summary>
        /// Picking tag 
        /// </summary>
		public String PickingTag;

        /// <summary>
        /// Pickwave item row id 
        /// </summary>
		public Int32 PickingWaveItemsRowId;

        /// <summary>
        /// Pickwave id 
        /// </summary>
		public Int32 PickingWaveId;

        /// <summary>
        /// Quatity picked 
        /// </summary>
		public Int32 PickedQuantity;

        /// <summary>
        /// Pickwave item state 
        /// </summary>
		public PickingWaveItemState ItemState;

        /// <summary>
        /// Collection of pickwave item totes. 
        /// </summary>
		public List<PickingWaveItemTote> Totes;

		public Int32? BatchInventoryId;

		public Int32 OrderId;

		public Guid OrderItemRowId;

		public Guid StockItemId;
	} 
}