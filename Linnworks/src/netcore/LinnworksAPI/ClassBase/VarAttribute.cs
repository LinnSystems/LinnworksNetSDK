using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class VarAttribute : LinnObject
	{
		public String Name { get; set; }

		public String ExtendedProperty { get; set; }

		public String Type { get; set; }

		public String TypeLabel { get; set; }
	} 
}