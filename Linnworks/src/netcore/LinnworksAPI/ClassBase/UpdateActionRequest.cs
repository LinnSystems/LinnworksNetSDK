using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateActionRequest : LinnObject
	{
		public Int32 pkActionId { get; set; }

		public Int32 fkConditionId { get; set; }

		public String ActionName { get; set; }

		public RulesEngineActionType ActionType { get; set; }

		public List<ActionPropertyRequest> Properties { get; set; }
	} 
}