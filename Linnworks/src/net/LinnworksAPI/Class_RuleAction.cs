using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class RuleAction
{ public Int32 pkActionId;
public String ActionName;
public ActionType ActionType;
public String ActionValue;
public Int32 fkConditionId;
public Int32 RuleVersion;
public Int32 fkRuleId;
 
} 
}