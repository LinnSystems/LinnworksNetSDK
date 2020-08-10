using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Pickwave item update request. 
    /// </summary>
    public class PickingWaveItemUpdateRequest
	{
        /// <summary>
        /// List of pickwave items to update 
        /// </summary>
		public List<PickingWaveItemUpdate> WaveItemUpdates { get; set; }
	} 
}