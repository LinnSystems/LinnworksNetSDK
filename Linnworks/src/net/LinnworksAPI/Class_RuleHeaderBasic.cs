using System;

namespace LinnworksAPI
{
    public class RuleHeaderBasic
    {
        public Int32 pkRuleId;
        public String RuleName;
        public Boolean Enabled;
        public Int32 RunOrder;
        public RuleSetType RuleType;
        public Int32? pkRuleId_Draft;
        public Boolean Draft;
        public String RuleTypeDisplayName;
    }
}