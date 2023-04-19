using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AssignedOption : LinnObject
	{
		public Int32 Id { get; set; }

		public Int32 IdV3 { get; set; }

		public String OptionName { get; set; }

		public String OptionDisplayName { get; set; }

		public Boolean MappedFromBC { get; set; }

		public Int32 AssignmentId { get; set; }

		public List<OptionValue> Values { get; set; }

		public String Type { get; set; }
	} 
}