using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OptionValue : LinnObject
	{
		public Boolean MappedFromBC { get; set; }

		public Int32? Id { get; set; }

		public Int32? IdV3 { get; set; }

		public Int32 SortOrder { get; set; }

		public String Label { get; set; }

		public OptionValueData OptionValueData { get; set; }
	} 
}