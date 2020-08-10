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
		public Int32 PickingWaveOrdersRowId;

        /// <summary>
        /// Pickwave id 
        /// </summary>
		public Int32 PickingWaveId;

        /// <summary>
        /// Order Id 
        /// </summary>
		public Int32 OrderId;

        /// <summary>
        /// Pick state 
        /// </summary>
		public PickingWaveOrderState PickState;

        /// <summary>
        /// Sort order 
        /// </summary>
		public Int32 SortOrder;

        /// <summary>
        /// Items count 
        /// </summary>
		public Int32 ItemCount;

        /// <summary>
        /// Picked items count 
        /// </summary>
		public Int32 PickedItemsCount;

        /// <summary>
        /// Pickwave order items. 
        /// </summary>
		public List<PickingWaveItemDetailed> Items;

        /// <summary>
        /// Relationship between pickwave items and composite parent rows. 
        /// </summary>
		public List<PickingWaveItemComposition> Composition;

        /// <summary>
        /// Internal guid orderid 
        /// </summary>
		public Guid OrderId_Guid;

        /// <summary>
        /// Is order processed 
        /// </summary>
		public Boolean IsProcessed;

        /// <summary>
        /// Is order hold or cancelled 
        /// </summary>
		public Boolean IsCancelled;

        /// <summary>
        /// Is order on hold status 
        /// </summary>
		public Boolean IsOnHold;

        /// <summary>
        /// Is order locked. 
        /// </summary>
		public Boolean IsLocked;

        /// <summary>
        /// Is order paid 
        /// </summary>
		public Boolean IsPaid;
	} 
}