using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Pickwave 
    /// </summary>
    public class PickingWave
	{
        /// <summary>
        /// Location Id 
        /// </summary>
		public Guid LocationId { get; set; }

        /// <summary>
        /// Allocated user id 
        /// </summary>
		public Int32? UserId { get; set; }

        /// <summary>
        /// Allocated user EmailAddress 
        /// </summary>
		public String EmailAddress { get; set; }

        /// <summary>
        /// Creation date 
        /// </summary>
		public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Order Count - Number of orders in pickwave. 
        /// </summary>
		public Int32 OrderCount { get; set; }

        /// <summary>
        /// Item Count - Number of items in pickwave. 
        /// </summary>
		public Int32 ItemCount { get; set; }

        /// <summary>
        /// Items Picked - Number of items picked in pickwave. 
        /// </summary>
		public Int32 ItemsPicked { get; set; }

        /// <summary>
        /// Orders Picked - Number of orders picked in pickwave. 
        /// </summary>
		public Int32 OrdersPicked { get; set; }

        /// <summary>
        /// Time taken in pickwave 
        /// </summary>
		public Int32 AccumulatedInProgressSeconds { get; set; }

        /// <summary>
        /// Start date time of pickwave 
        /// </summary>
		public DateTime? StartTime { get; set; }

        /// <summary>
        /// End date time of pickwave 
        /// </summary>
		public DateTime? EndTime { get; set; }

        /// <summary>
        /// Pickwave group type 
        /// </summary>
		public PickingWaveGroupType GroupType { get; set; }

        /// <summary>
        /// Orders in pickwave. This data is not returned if just headers are requested. 
        /// </summary>
		public List<PickingWaveOrder> Orders { get; set; }

		public PickingWaveOptions Options { get; set; }

		public Int32 PickingWaveId { get; set; }

		public PickingWaveState State { get; set; }
	} 
}