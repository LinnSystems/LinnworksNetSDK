using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// See spa_lw\linnworks.spa.commondata\Generic\GenericEnumDescriptor.cs for example enum 
    /// </summary>
    public class GenericEnumDescriptor
	{
		public String Description { get; set; }

		public String Value { get; set; }

		public Boolean IsDefault { get; set; }
	} 
}