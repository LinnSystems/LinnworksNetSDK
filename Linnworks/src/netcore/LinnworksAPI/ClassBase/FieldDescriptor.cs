using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class FieldDescriptor
	{
		public String Name { get; set; }

		public String FieldName { get; set; }

		public String FieldGroup { get; set; }

		public Boolean IsASet { get; set; }

		public List<EvaluatorGroup> ValidEvaluatorGroups { get; set; }

		public String Key { get; set; }

		public String KeyDisplayName { get; set; }

		public Boolean HasKeyOptions { get; set; }

		public Boolean HasAttributeKey { get; set; }

		public Boolean HasOptions { get; set; }

		public DisplayType DisplayType { get; set; }

		public Boolean ExactMatchRequired { get; set; }
	} 
}