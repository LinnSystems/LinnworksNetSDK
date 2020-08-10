using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Country region information to update 
    /// </summary>
    public class UpdateCountryRegionsRequest
	{
		public List<CountryRegion> regions { get; set; }
	} 
}