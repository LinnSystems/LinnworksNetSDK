using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdatePickedItemDeltaRequestItem
	{
        /// <summary>
        /// Picking wave row id 
        /// </summary>
		public Int32 PickingWaveItemsRowId { get; set; }

        /// <summary>
        /// Tote id 
        /// </summary>
		public Int32? ToteId { get; set; }

        /// <summary>
        /// Tray tag (optional) 
        /// </summary>
		public String TrayTag { get; set; }

        /// <summary>
        /// Picked quantity delta 
        /// </summary>
		public Int32 PickedQuantityDelta { get; set; }
	} 
}