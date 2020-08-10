using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CountryRegion
	{
        /// <summary>
        /// Region row ID 
        /// </summary>
		public Int32 pkRegionRowId { get; set; }

        /// <summary>
        /// Region code 
        /// </summary>
		public String RegionCode { get; set; }

        /// <summary>
        /// Region name 
        /// </summary>
		public String RegionName { get; set; }

        /// <summary>
        /// Tax rate 
        /// </summary>
		public Double? TaxRate { get; set; }

        /// <summary>
        /// Country ID 
        /// </summary>
		public Guid fkCountryId { get; set; }

		public CountryRegionReplaceWith ReplaceWith { get; set; }

        /// <summary>
        /// If this region is home region 
        /// </summary>
		public Boolean IsHomeRegion { get; set; }

        /// <summary>
        /// Quantity of tags 
        /// </summary>
		public Int32 TagsCount { get; set; }
	} 
}