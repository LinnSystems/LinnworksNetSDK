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
		public Int32 pkRegionRowId;

        /// <summary>
        /// Region code 
        /// </summary>
		public String RegionCode;

        /// <summary>
        /// Region name 
        /// </summary>
		public String RegionName;

        /// <summary>
        /// Tax rate 
        /// </summary>
		public Double? TaxRate;

        /// <summary>
        /// Country ID 
        /// </summary>
		public Guid fkCountryId;

		public CountryRegionReplaceWith ReplaceWith;

        /// <summary>
        /// If this region is home region 
        /// </summary>
		public Boolean IsHomeRegion;

        /// <summary>
        /// Quantity of tags 
        /// </summary>
		public Int32 TagsCount;
	} 
}