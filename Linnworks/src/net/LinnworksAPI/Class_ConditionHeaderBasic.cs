using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class ConditionHeaderBasic
{ public Int32 pkConditionId;
public Int32? fkParentConditionId;
public Int32 fkRuleId;
public String ConditionName;
public Boolean Enabled;
public List<ConditionItemBasic> Conditions;
 
} 
}