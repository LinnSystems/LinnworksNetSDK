using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteOrdersFromPickingWavesRequest : LinnObject
	{
        /// <summary>
        /// List of Linnworks OrderIds 
        /// </summary>
		public List<Int32> OrderIds { get; set; }
	} 
}