using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PrintZoneConfig : LinnObject
	{
		public String PrintZoneCode { get; set; }

		public String PrinterDestination { get; set; }

		public String PrinterName { get; set; }
	} 
}