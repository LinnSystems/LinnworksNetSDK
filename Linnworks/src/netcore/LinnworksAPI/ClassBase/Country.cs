using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Country
	{
        /// <summary>
        /// Country ID 
        /// </summary>
		public Guid CountryId { get; set; }

        /// <summary>
        /// Country name 
        /// </summary>
		public String CountryName { get; set; }

        /// <summary>
        /// Country code 
        /// </summary>
		public String CountryCode { get; set; }

        /// <summary>
        /// Continent 
        /// </summary>
		public String Continent { get; set; }

        /// <summary>
        /// Currency 
        /// </summary>
		public String Currency { get; set; }

        /// <summary>
        /// If customs required 
        /// </summary>
		public Boolean CustomsRequired { get; set; }

        /// <summary>
        /// Tax rate (null - will use system default tax rate) 
        /// </summary>
		public Double? TaxRate { get; set; }

        /// <summary>
        /// Address format 
        /// </summary>
		public String AddressFormat { get; set; }

        /// <summary>
        /// Country region 
        /// </summary>
		public List<CountryRegion> Regions { get; set; }

        /// <summary>
        /// Count of regions 
        /// </summary>
		public Int32 RegionsCount { get; set; }
	} 
}