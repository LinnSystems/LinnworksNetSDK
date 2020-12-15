using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Pickwave order 
    /// </summary>
    public class PickingWaveOrder
	{
        /// <summary>
        /// Pickwave order id 
        /// </summary>
		public Int32 PickingWaveOrdersRowId { get; set; }

        /// <summary>
        /// Pickwave id 
        /// </summary>
		public Int32 PickingWaveId { get; set; }

        /// <summary>
        /// Order Id 
        /// </summary>
		public Int32 OrderId { get; set; }

        /// <summary>
        /// Pick state 
        /// </summary>
		public PickingWaveOrderState PickState { get; set; }

        /// <summary>
        /// Sort order 
        /// </summary>
		public Int32 SortOrder { get; set; }

        /// <summary>
        /// Items count 
        /// </summary>
		public Int32 ItemCount { get; set; }

        /// <summary>
        /// Picked items count 
        /// </summary>
		public Int32 PickedItemsCount { get; set; }

        /// <summary>
        /// Pickwave order items. 
        /// </summary>
		public List<PickingWaveItem> Items { get; set; }
	} 
}