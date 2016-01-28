using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class FieldMap
    {
        public String SourceName;
        public String MapsTo;
        public String FilterField;
        public Type DataType;
        public String Expression;
        public Boolean FilteringAllowed;
        public FilteringTypes FilteringType;
        public Filters Filters;
        public Boolean Visible;
        public List<SubQueryOutputMappingSelectionField> SubQuerySelection;
        public Boolean IsSubQueryColumn;
    }
}