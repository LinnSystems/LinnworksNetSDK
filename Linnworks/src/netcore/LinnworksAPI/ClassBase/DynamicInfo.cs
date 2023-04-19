using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DynamicInfo : LinnObject
	{
		public Int32 Capacity { get; set; }

		public Int32 Count { get; set; }

		public Object Item { get; set; }
	} 
}