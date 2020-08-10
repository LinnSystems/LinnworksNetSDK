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
		public Int32 PickingWaveItemsRowId;

        /// <summary>
        /// Tote id 
        /// </summary>
		public Int32? ToteId;

        /// <summary>
        /// Tray tag (optional) 
        /// </summary>
		public String TrayTag;

        /// <summary>
        /// Picked quantity delta 
        /// </summary>
		public Int32 PickedQuantityDelta;
	} 
}