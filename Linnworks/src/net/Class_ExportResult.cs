using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ExportResult
    {
        public ExportResultType ResultType;
        public Int32 RowsExported;
        public List<String> Errors;
    }
}