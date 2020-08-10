using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateCountryRegionsRequest
	{
        /// <summary>
        /// List of country regions 
        /// </summary>
		public List<CountryRegion> regions { get; set; }
	} 
}