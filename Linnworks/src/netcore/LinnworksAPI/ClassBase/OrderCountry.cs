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
        /// Country continent 
        /// </summary>
		public String Continent { get; set; }

        /// <summary>
        /// If customs required 
        /// </summary>
		public Boolean CustomsRequired { get; set; }

        /// <summary>
        /// Country tax rate 
        /// </summary>
		public Double TaxRate { get; set; }
	} 
}