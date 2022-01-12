using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddExtendedPropertiesResponse
	{
        /// <summary>
        /// The number of extended properties that were added 
        /// </summary>
		public Int32 ExtendedPropertiesInserted { get; set; }

        /// <summary>
        /// An array of errors created when attempting to add 
        /// </summary>
		public String[] Errors { get; set; }
	} 
}