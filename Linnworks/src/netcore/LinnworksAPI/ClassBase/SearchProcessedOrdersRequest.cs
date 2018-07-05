using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SearchProcessedOrdersRequest
	{
		public String SearchTerm;

		public List<SearchFilters> SearchFilters;

		public DateField? DateField;

		public DateTime? FromDate;

		public DateTime? ToDate;

		public Int32 PageNumber;

		public Int32 ResultsPerPage;

		public SearchSorting SearchSorting;
	} 
}