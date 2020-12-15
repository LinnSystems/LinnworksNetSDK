using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Pickwave order item 
    /// </summary>
    public class PickingWaveItem
	{
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
        /// Tote Barcode 
        /// </summary>
		public String TotBarcode { get; set; }

		public Int32 SortOrder { get; set; }

		public Int32 ToPickQuantity { get; set; }

		public Int32? TOTId { get; set; }

		public String TrayTag { get; set; }

		public String PickingTag { get; set; }

		public PickingWaveItemState ItemState { get; set; }

		public Int32? BatchInventoryId { get; set; }

		public Int32 OrderId { get; set; }

		public Guid OrderItemRowId { get; set; }

		public Guid StockItemId { get; set; }
	} 
}