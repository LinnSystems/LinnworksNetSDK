using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Dimension 
    /// </summary>
    public class Dimension : LinnObject
	{
        /// <summary>
        /// Width 
        /// </summary>
		public Decimal Width { get; set; }

        /// <summary>
        /// Depth 
        /// </summary>
		public Decimal Depth { get; set; }

        /// <summary>
        /// Height 
        /// </summary>
		public Decimal Height { get; set; }
	} 
}