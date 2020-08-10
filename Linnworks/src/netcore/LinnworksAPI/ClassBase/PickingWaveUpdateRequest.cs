using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickingWaveUpdateRequest
	{
        /// <summary>
        /// Pickwave id 
        /// </summary>
		public Int32 PickingWaveId { get; set; }

        /// <summary>
        /// Allocated user id, null will keep the current assigned user, -1 will de-allocated the user from the pickwave. 
        /// </summary>
		public Int32? UserId { get; set; }

        /// <summary>
        /// Current state of pickwave 
        /// </summary>
		public PickingWaveState? State { get; set; }

        /// <summary>
        /// Start date time of pickwave 
        /// </summary>
		public DateTime? StartTime { get; set; }

        /// <summary>
        /// End date time of pickwave 
        /// </summary>
		public DateTime? EndTime { get; set; }
	} 
}