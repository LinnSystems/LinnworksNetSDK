using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class GenericPagedResult<VariationGroup>
    {
        public Int32 PageNumber;
        public Int32 EntriesPerPage;
        public Int32 TotalEntries;
        public Int32 TotalPages;
        public List<VariationGroup> Data;
    }
}