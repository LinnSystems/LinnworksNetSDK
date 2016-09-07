using System;

namespace LinnworksAPI
{
    public class Filter
    {
        public FilterNameType FilterName;
        public String DisplayName;
        public String FilterNameExact;
        public FieldType Field;
        public ConditionType Condition;
        public FilterLogicType FilterLogic;
        public String Value;
    }
}