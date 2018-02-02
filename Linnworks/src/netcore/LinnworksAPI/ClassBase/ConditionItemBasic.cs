using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConditionItemBasic
	{
		public Int32 pkConditionItemId;

		public Int32 fkConditionId;

		public String FieldName;

		public EvaluatorType Evaluation;

		public List<String> Values;

		public String KeyValue;
	} 
}