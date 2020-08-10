using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DownloadOrdersToCSVRequest
	{
        /// <summary>
        /// Search Term 
        /// </summary>
		public String SearchTerm { get; set; }

        /// <summary>
        /// Search Filters 
        /// </summary>
		public List<SearchFilters> SearchFilters { get; set; }

        /// <summary>
        /// Date Field Type 
        /// </summary>
		public DateField? DateField { get; set; }

        /// <summary>
        /// From Date 
        /// </summary>
		public DateTime? FromDate { get; set; }

        /// <summary>
        /// To Date 
        /// </summary>
		public DateTime? ToDate { get; set; }

        /// <summary>
        /// Search Sorting 
        /// </summary>
		public SearchSorting SearchSorting { get; set; }
	} 
}