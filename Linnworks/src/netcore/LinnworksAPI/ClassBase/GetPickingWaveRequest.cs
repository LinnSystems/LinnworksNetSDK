using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Get pickwave request 
    /// </summary>
    public class GetPickingWaveRequest : LinnObject
	{
        /// <summary>
        /// Pickwave id 
        /// </summary>
		public Int32 PickingWaveId { get; set; }
	} 
}