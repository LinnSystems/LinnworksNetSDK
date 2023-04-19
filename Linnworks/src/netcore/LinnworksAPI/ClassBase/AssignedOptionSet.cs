using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AssignedOptionSet : LinnObject
	{
		public Int32 Id { get; set; }

		public String Name { get; set; }

		public Boolean MappedFromBC { get; set; }

		public List<AssignedOption> Options { get; set; }
	} 
}