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
		public String Field;

        /// <summary>
        /// Name 
        /// </summary>
		public String Name;

        /// <summary>
        /// If search for all dates 
        /// </summary>
		public Boolean AllowForAllDates;

        /// <summary>
        /// If search is exact 
        /// </summary>
		public Boolean ExactSearchOptional;
	} 
}