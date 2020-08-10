using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickingWaveOrderDetailed
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
		public List<PickingWaveItemDetailed> Items { get; set; }

        /// <summary>
        /// Relationship between pickwave items and composite parent rows. 
        /// </summary>
		public List<PickingWaveItemComposition> Composition { get; set; }

        /// <summary>
        /// Internal guid orderid 
        /// </summary>
		public Guid OrderId_Guid { get; set; }

        /// <summary>
        /// Is order processed 
        /// </summary>
		public Boolean IsProcessed { get; set; }

        /// <summary>
        /// Is order hold or cancelled 
        /// </summary>
		public Boolean IsCancelled { get; set; }

        /// <summary>
        /// Is order on hold status 
        /// </summary>
		public Boolean IsOnHold { get; set; }

        /// <summary>
        /// Is order locked. 
        /// </summary>
		public Boolean IsLocked { get; set; }

        /// <summary>
        /// Is order paid 
        /// </summary>
		public Boolean IsPaid { get; set; }
	} 
}