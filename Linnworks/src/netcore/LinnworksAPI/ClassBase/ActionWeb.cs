using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ActionWeb
	{
		public Int32? pkActionId;

		public Int32 fkConditionId;

		public String ActionName;

		public ActionType ActionType;

		public List<ActionWebProperty> Properties;
	} 
}