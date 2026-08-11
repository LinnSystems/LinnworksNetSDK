using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickingWaveDespatchData : LinnObject
	{
        /// <summary>
        /// Pickwave Id 
        /// </summary>
		public Int32 PickingWaveId { get; set; }

        /// <summary>
        /// Numeric Order Id 
        /// </summary>
		public Int32 OrderId { get; set; }

        /// <summary>
        /// The orderId represented as a Guid 
        /// </summary>
		public Guid OrderIdGuid { get; set; }

        /// <summary>
        /// Linnworks Stock item identifier 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// The sequence of this item in its parent pickwave 
        /// </summary>
		public Int32 SortOrder { get; set; }

        /// <summary>
        /// The identifier for the tote it was picked into.
        /// If the item was not picked into a tote, this will be null. 
        /// </summary>
		public Int32? ToteId { get; set; }

        /// <summary>
        /// The tray this item was picked into.
        /// If the item was not picked into a tray, this will be empty 
        /// </summary>
		public String TrayNumber { get; set; }

        /// <summary>
        /// Barcode assigned to the scanned tote.
        /// If the item was not picked into a tote, this will be empty 
        /// </summary>
		public String ToteBarcode { get; set; }

        /// <summary>
        /// The quantity of this item that was to be picked 
        /// </summary>
		public Int32 ToPickQty { get; set; }

        /// <summary>
        /// The quantity of this item that has been picked 
        /// </summary>
		public Int32 PickedQty { get; set; }
	} 
}