using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PrintZone : LinnObject
	{
        /// <summary>
        /// The unique identifier for the print zone 
        /// </summary>
		public Int32 PrintZoneId { get; set; }

        /// <summary>
        /// Unique code for the print zone 
        /// </summary>
		public String PrintZoneCode { get; set; }

        /// <summary>
        /// Name for the print zone 
        /// </summary>
		public String PrintZoneName { get; set; }
	} 
}