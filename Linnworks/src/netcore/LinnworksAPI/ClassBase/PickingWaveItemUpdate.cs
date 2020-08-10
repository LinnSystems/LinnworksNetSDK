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
		public Int32 PickingWaveItemsRowId;

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
        /// Picked quantity 
        /// </summary>
		public Int32? PickedQuantity;

        /// <summary>
        /// Order State 
        /// </summary>
		public PickingWaveOrderState? OrderState;

        /// <summary>
        /// Item State 
        /// </summary>
		public PickingWaveItemState? ItemState;

        /// <summary>
        /// To Pick Quantity 
        /// </summary>
		public Int32? ToPickQuantity;
	} 
}