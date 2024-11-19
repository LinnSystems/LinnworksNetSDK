using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GenericEnumDescriptor : LinnObject
	{
		public String Description { get; set; }

		public String Value { get; set; }

		public Boolean IsDefault { get; set; }
	} 
}