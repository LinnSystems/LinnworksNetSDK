using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class RuleConditionHeader
{ public Int32 pkConditionId;
public Int32 fkRuleId;
public Int32 RunOrder;
public Boolean Enabled;
public String ConditionName;
public Int32 fkParentConditionId;
public List<IRuleConditionItem> Conditions;
public RuleAction Action;
public List<RuleConditionHeader> Subrules;
 
} 
}