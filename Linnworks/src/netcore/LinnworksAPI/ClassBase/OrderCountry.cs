using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderCountry
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
        /// Country continent 
        /// </summary>
		public String Continent;

        /// <summary>
        /// If customs required 
        /// </summary>
		public Boolean CustomsRequired;

        /// <summary>
        /// Country tax rate 
        /// </summary>
		public Double TaxRate;
	} 
}