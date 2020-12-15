using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ParameterDefinition
	{
		public String Type { get; set; }

		public String Name { get; set; }

		public Boolean IsRequired { get; set; }

		public String DefaultValue { get; set; }

		public String FriendlyName { get; set; }

		public String ParameterDescription { get; set; }

		public String RegexValidation { get; set; }

		public String RegexErrorMessage { get; set; }

		public Boolean MustBeSpecified1 { get; set; }

		public Boolean isHidden { get; set; }

		public Boolean isReadOnly { get; set; }

		public String GroupName { get; set; }

		public Int32 Sortorder { get; set; }
	} 
}