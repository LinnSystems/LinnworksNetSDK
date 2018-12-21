using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{
    public class ConfigItem<T>
    {
        public Boolean Loaded;

        public Int32 pkPropertyId;

        public Boolean IsChanged;

        public T PropertyValue;

        public String PropertyType;
    }
}