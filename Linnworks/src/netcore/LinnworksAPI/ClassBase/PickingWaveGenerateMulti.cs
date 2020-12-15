using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickingWaveGenerateMulti
	{
        /// <summary>
        /// Orders 
        /// </summary>
		public List<PickingWaveGenerateOrderMulti> Orders { get; set; }

        /// <summary>
        /// Pickwave group type (optional, if not set parent sort will be used) 
        /// </summary>
		public PickingWaveGroupType? GroupType { get; set; }
	} 
}