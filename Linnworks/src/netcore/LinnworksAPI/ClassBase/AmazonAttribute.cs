using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AmazonAttribute : LinnObject
	{
		public String AttrName { get; set; }

		public String DisplayName { get; set; }

		public String LinnworksProperty { get; set; }

		public String ListingProperty { get; set; }

		public String DefaultValue { get; set; }

		public RequirementTypes Required { get; set; }

		public AmazonAttributeType Type { get; set; }

		public String RealType { get; set; }

		public List<LinnLiveKeyValue> ValidValues { get; set; }

		public String Path { get; set; }

		public Boolean IsVariation { get; set; }

		public Boolean IsInvalidValue { get; set; }

		public String ErrorMessage { get; set; }

		public Boolean CanBeVariation { get; set; }
	} 
}