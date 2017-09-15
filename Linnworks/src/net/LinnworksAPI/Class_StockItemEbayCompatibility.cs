using System;

namespace LinnworksAPI
{
    public class StockItemEbayCompatibility
    {
        public Guid FkStockItemId;
        public Guid FkCompatibilityListId;
        public String CompatibilityNotes;
        public String Value;
        public String IncludeYears;
        public String ExcludeYears;
    }
}