using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickingWaveGenerate
	{
        /// <summary>
        /// Location Id 
        /// </summary>
		public Guid LocationId;

        /// <summary>
        /// Allocated user id 
        /// </summary>
		public Int32? UserId;

        /// <summary>
        /// Pickwave items 
        /// </summary>
		public List<PickingWaveGenerateOrder> Orders;

        /// <summary>
        /// Pickwave group type 
        /// </summary>
		public PickingWaveGroupType GroupType;
	} 
}