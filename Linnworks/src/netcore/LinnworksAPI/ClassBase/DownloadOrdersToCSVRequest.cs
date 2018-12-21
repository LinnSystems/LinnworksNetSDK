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
		public String SearchTerm;

        /// <summary>
        /// Search Filters 
        /// </summary>
		public List<SearchFilters> SearchFilters;

        /// <summary>
        /// Date Field Type 
        /// </summary>
		public DateField? DateField;

        /// <summary>
        /// From Date 
        /// </summary>
		public DateTime? FromDate;

        /// <summary>
        /// To Date 
        /// </summary>
		public DateTime? ToDate;

        /// <summary>
        /// Search Sorting 
        /// </summary>
		public SearchSorting SearchSorting;
	} 
}