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
		public Guid CountryId;

        /// <summary>
        /// Country name 
        /// </summary>
		public String CountryName;

        /// <summary>
        /// Country code 
        /// </summary>
		public String CountryCode;

        /// <summary>
        /// Continent 
        /// </summary>
		public String Continent;

        /// <summary>
        /// Currency 
        /// </summary>
		public String Currency;

        /// <summary>
        /// If customs required 
        /// </summary>
		public Boolean CustomsRequired;

        /// <summary>
        /// Tax rate (null - will use system default tax rate) 
        /// </summary>
		public Double? TaxRate;

        /// <summary>
        /// Address format 
        /// </summary>
		public String AddressFormat;

        /// <summary>
        /// Country region 
        /// </summary>
		public List<CountryRegion> Regions;

        /// <summary>
        /// Count of regions 
        /// </summary>
		public Int32 RegionsCount;
	} 
}