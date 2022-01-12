using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Describes GeoPosition 
    /// </summary>
    public class GeoPosition
	{
        /// <summary>
        /// X position 
        /// </summary>
		public Decimal X { get; set; }

        /// <summary>
        /// Y position 
        /// </summary>
		public Decimal Y { get; set; }

        /// <summary>
        /// Z position 
        /// </summary>
		public Decimal Z { get; set; }
	} 
}