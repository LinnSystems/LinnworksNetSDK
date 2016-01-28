using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class IExportType
    {
        public ExportType ExportType;
        public String ExportName;
        public String Description;
        public Boolean UIVisible;
        public Mapping DefaultMapping;
        public Int32 BatchSize;
        public String ScriptGUIDField;
        public List<SubQuery> SubQueries;
    }
}