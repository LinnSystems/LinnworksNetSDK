using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class FieldDescriptor
	{
		public String Name;

		public String FieldName;

		public String FieldGroup;

		public Boolean IsASet;

		public List<EvaluatorGroup> ValidEvaluatorGroups;

		public String Key;

		public String KeyDisplayName;

		public Boolean HasKeyOptions;

		public Boolean HasAttributeKey;

		public Boolean HasOptions;

		public DisplayType DisplayType;

		public Boolean ExactMatchRequired;
	} 
}