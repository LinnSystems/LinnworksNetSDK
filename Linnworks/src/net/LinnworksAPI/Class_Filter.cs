using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class Filter
    {
        public FilterNameType FilterName;
        public String DisplayName;
        public List<String> FilterNameExact;
        public FieldType Field;
        public ConditionType Condition;
        public String ConditionDisplayName;
        public String Value;
    }
}