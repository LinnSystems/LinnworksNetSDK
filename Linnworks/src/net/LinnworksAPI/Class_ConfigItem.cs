using System;

namespace LinnworksAPI
{
    public class ConfigItem<Boolean>
    {
        public Boolean Loaded;
        public Int32 pkPropertyId;
        public Boolean IsChanged;
        public Boolean PropertyValue;
        public String PropertyType;
    }
}