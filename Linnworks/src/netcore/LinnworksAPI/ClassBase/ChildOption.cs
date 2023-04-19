using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChildOption : LinnObject
	{
		public Int32 OptionId { get; set; }

		public Int32 ValueId { get; set; }

		public String Name { get; set; }

		public String Label { get; set; }
	} 
}