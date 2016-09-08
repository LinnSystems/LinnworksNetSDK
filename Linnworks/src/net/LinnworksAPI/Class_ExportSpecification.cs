using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ExportSpecification
    {
        public Boolean ExportColumnNames;
        public String Delimiter;
        public String Escape;
        public String CustomScript;
        public ExportGenericFeed Feed;
        public List<ExportColumn> ColumnMappings;
        public List<ExecutionOption> ExecutionOptions;
    }
}