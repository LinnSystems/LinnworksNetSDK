using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class CustomScriptResult
    {
        public Boolean IsError;
        public String ErrorMessage;
        public Int64 TotalResults;
        public List<CustomScriptColumn> Columns;
        public List<Dictionary<String, Object>> Results;
    }
}