using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RuleEvaluationResult : LinnObject
	{
		public Int32 LastConditionId { get; set; }

		public Int32 LastActionId { get; set; }
	} 
}