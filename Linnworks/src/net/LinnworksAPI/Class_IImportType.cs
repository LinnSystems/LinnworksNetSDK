using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class IImportType
    {
        public ImportType Type;
        public String FriendlyName;
        public String Description;
        public Boolean UIVisible;
        public List<SimpleColumn> AvailableColumns;
    }
}