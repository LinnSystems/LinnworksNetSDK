using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickingWaveItemUpdate
	{
        /// <summary>
        /// Pickwave item row id 
        /// </summary>
		public Int32 PickingWaveItemsRowId { get; set; }

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
        /// Picked quantity 
        /// </summary>
		public Int32? PickedQuantity { get; set; }

        /// <summary>
        /// Order State 
        /// </summary>
		public PickingWaveOrderState? OrderState { get; set; }

        /// <summary>
        /// Item State 
        /// </summary>
		public PickingWaveItemState? ItemState { get; set; }

        /// <summary>
        /// To Pick Quantity 
        /// </summary>
		public Int32? ToPickQuantity { get; set; }
	} 
}