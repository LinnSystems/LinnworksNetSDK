using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Shipping service mapping between ShipStation and linnworks 
    /// </summary>
    public class ShipService
	{
        /// <summary>
        /// The unique identifier for the ShipStation service 
        /// </summary>
		public Guid ShipStationServiceId { get; set; }

        /// <summary>
        /// The unique identifier for the linnworks service 
        /// </summary>
		public Guid LinnworksServiceId { get; set; }
	} 
}