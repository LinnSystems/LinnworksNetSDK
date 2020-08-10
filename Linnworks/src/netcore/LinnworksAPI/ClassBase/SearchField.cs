using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Class represents the list of fields to be included it the where clause for searching 
    /// </summary>
    public class SearchField
	{
        /// <summary>
        /// Search field 
        /// </summary>
		public String Field { get; set; }

        /// <summary>
        /// Name 
        /// </summary>
		public String Name { get; set; }

        /// <summary>
        /// If search for all dates 
        /// </summary>
		public Boolean AllowForAllDates { get; set; }

        /// <summary>
        /// If search is exact 
        /// </summary>
		public Boolean ExactSearchOptional { get; set; }
	} 
}