using System;

namespace LinnworksAPI
{
    public class ConfigPropertySelectionList<SelectStringValueOption, Guid>
    {
        public GetSelectionList<SelectStringValueOption> OnGetSelectionList;
        public Boolean Loaded;
        public Int32 pkPropertyId;
        public Boolean IsChanged;
        public Guid PropertyValue;
        public String PropertyType;
    }
}