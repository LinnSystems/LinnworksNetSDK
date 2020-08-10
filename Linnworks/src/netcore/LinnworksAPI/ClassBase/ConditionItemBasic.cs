using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConditionItemBasic
	{
		public Int32 pkConditionItemId { get; set; }

		public Int32 fkConditionId { get; set; }

		public String FieldName { get; set; }

		public EvaluatorType Evaluation { get; set; }

		public List<String> Values { get; set; }

		public String KeyValue { get; set; }
	} 
}