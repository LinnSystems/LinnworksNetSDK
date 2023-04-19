using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EbaySpecification : LinnObject
	{
		public String SpecName { get; set; }

		public String DefaultValue { get; set; }

		public String LinnworksProperty { get; set; }

		public List<String> PossibleValues { get; set; }

		public AssociationTable AssociationTable { get; set; }

		public HashSet<Int32> CategoryIds { get; set; }

		public Boolean IsUserDefined { get; set; }

		public Boolean IsRequired { get; set; }
	} 
}