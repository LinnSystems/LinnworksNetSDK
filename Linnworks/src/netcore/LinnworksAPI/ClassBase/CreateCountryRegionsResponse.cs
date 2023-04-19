using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateCountryRegionsResponse : LinnObject
	{
		public List<CountryRegion> regions { get; set; }
	} 
}