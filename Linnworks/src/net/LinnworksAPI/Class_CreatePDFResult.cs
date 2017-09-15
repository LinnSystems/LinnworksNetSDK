using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class CreatePDFResult
    {
        public List<PrintError> KeyedError;
        public String URL;
        public List<Guid> IdsProcessed;
        public Dictionary<String, List<Guid>> ProcessedIds;
        public List<String> PrintErrors;
    }
}