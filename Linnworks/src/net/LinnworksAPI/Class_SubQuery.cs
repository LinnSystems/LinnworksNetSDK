using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class SubQuery
    {
        public String Name;
        public String DisplayName;
        public String Query;
        public String BindingKey;
        public String ValueField;
        public String EmptyValue;
        public List<SubQuerySelectionField> SelectionFields;
    }
}