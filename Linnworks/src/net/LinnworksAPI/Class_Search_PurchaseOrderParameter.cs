using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class Search_PurchaseOrderParameter
    {
        public DateTime? DateFrom;
        public DateTime? DateTo;
        public PurchaseOrderStatus? Status;
        public String ReferenceLike;
        public Int32 EntriesPerPage;
        public Int32 PageNumber;
        public List<Guid> Location;
        public List<Guid> Supplier;
    }
}