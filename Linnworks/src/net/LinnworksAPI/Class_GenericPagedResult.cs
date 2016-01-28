using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class GenericPagedResult<String>
    {
        public Int32 PageNumber;
        public Int32 EntriesPerPage;
        public Int32 TotalEntries;
        public Int32 TotalPages;
        public List<String> Data;
    }
}