using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Search_Stock_ByKey
	{
        /// <summary>
        /// Item ID 
        /// </summary>
		public String Key { get; set; }

        /// <summary>
        /// Location ID 
        /// </summary>
		public Guid LocationId { get; set; }
	} 
}