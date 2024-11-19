using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickupLocationTime : LinnObject
	{
		public String EBayLocation { get; set; }

		public Int32 FulfillmentValue { get; set; }

		public String FulfillmentType { get; set; }

		public String ExtendedPropertyValue { get; set; }

		public String ExtendedPropertyType { get; set; }
	} 
}