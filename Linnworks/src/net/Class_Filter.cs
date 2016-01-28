using System;

namespace LinnworksAPI
{
    public class Filter
    {
        public FilterNameType FilterName;
        public String FilterNameExact;
        public FieldType Field;
        public ConditionType Condition;
        public String Value;
    }
}