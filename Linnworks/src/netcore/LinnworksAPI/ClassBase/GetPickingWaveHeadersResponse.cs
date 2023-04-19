using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetPickingWaveHeadersResponse : LinnObject
	{
        /// <summary>
        /// List of pickingwave headers without order details 
        /// </summary>
		public List<PickingWave> PickwaveHeaders { get; set; }
	} 
}