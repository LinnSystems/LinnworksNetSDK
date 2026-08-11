using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetAllPrintZonesResponse : LinnObject
	{
		public List<PrintZone> PrintZones { get; set; }
	} 
}