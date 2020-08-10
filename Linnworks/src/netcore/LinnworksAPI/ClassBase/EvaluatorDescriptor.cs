using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EvaluatorDescriptor
	{
		public EvaluatorType EvaluatorType { get; set; }

		public ClientEvaluatorGroupType ClientType { get; set; }

		public String ClientTypeName { get; set; }

		public EvaluatorGroup EvaluatorGroup { get; set; }

		public String Description { get; set; }

		public Int32 GroupIndex { get; set; }

		public Int32 EvalIndex { get; set; }
	} 
}