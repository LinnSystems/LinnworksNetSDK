using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetAvailableTimeZonesResponse
	{
		public IEnumerable<AvailableTimeZone> TimeZones { get; set; }
	} 
}