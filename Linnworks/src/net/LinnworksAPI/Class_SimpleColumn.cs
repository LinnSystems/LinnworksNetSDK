using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class SimpleColumn
    {
        public List<String> ColumnsRequired;
        public List<String> PreImportQueries;
        public List<String> PostImportQueries;
        public Boolean DisableTriggers;
        public Object DefaultValueIfMissing;
        public String ColumnUpdateScript;
        public PreExecuteQueriesProcessDelegate PreExecuteQueriesProcess;
        public Type Type;
        public String ColumnName;
        public Boolean Required;
    }
}