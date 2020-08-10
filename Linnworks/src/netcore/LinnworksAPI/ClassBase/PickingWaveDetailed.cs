using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickingWaveDetailed
	{
        /// <summary>
        /// Pickwave id 
        /// </summary>
		public Int32 PickingWaveId;

        /// <summary>
        /// Location Id 
        /// </summary>
		public Guid LocationId;

        /// <summary>
        /// Allocated user id 
        /// </summary>
		public Int32? UserId;

        /// <summary>
        /// Allocated user EmailAddress 
        /// </summary>
		public String EmailAddress;

        /// <summary>
        /// Creation date 
        /// </summary>
		public DateTime CreatedDate;

        /// <summary>
        /// Order Count - Number of orders in pickwave. 
        /// </summary>
		public Int32 OrderCount;

        /// <summary>
        /// Item Count - Number of items in pickwave. 
        /// </summary>
		public Int32 ItemCount;

        /// <summary>
        /// Items Picked - Number of items picked in pickwave. 
        /// </summary>
		public Int32 ItemsPicked;

        /// <summary>
        /// Orders Picked - Number of orders picked in pickwave. 
        /// </summary>
		public Int32 OrdersPicked;

        /// <summary>
        /// Current state of pickwave 
        /// </summary>
		public PickingWaveState State;

        /// <summary>
        /// Time taken in pickwave 
        /// </summary>
		public Int32 AccumulatedInProgressSeconds;

        /// <summary>
        /// Start date time of pickwave 
        /// </summary>
		public DateTime? StartTime;

        /// <summary>
        /// End date time of pickwave 
        /// </summary>
		public DateTime? EndTime;

        /// <summary>
        /// Pickwave group type 
        /// </summary>
		public PickingWaveGroupType GroupType;

        /// <summary>
        /// Orders in pickwave. 
        /// </summary>
		public List<PickingWaveOrderDetailed> Orders;

		public PickingWaveOptions Options;
	} 
}