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
		public Guid LocationId { get; set; }

        /// <summary>
        /// Allocated user id 
        /// </summary>
		public Int32? UserId { get; set; }

        /// <summary>
        /// Pickwave items 
        /// </summary>
		public List<PickingWaveGenerateOrder> Orders { get; set; }

        /// <summary>
        /// Collection of pickwaves and their orders to generate. All order singular or composite child row ids must be provided, if batches exist on the order item then batch id must be supplied); 
        /// </summary>
		public List<PickingWaveGenerateMulti> Pickwaves { get; set; }

        /// <summary>
        /// Pickwave group type 
        /// </summary>
		public PickingWaveGroupType GroupType { get; set; }
	} 
}