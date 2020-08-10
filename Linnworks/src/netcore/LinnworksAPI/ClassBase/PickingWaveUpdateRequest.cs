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
		public Int32 PickingWaveId;

        /// <summary>
        /// Allocated user id, null will keep the current assigned user, -1 will de-allocated the user from the pickwave. 
        /// </summary>
		public Int32? UserId;

        /// <summary>
        /// Current state of pickwave 
        /// </summary>
		public PickingWaveState? State;

        /// <summary>
        /// Start date time of pickwave 
        /// </summary>
		public DateTime? StartTime;

        /// <summary>
        /// End date time of pickwave 
        /// </summary>
		public DateTime? EndTime;
	} 
}