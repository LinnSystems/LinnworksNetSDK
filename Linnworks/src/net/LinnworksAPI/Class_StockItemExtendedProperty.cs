using System;

namespace LinnworksAPI
{
    public class StockItemExtendedProperty
    {
        public Guid pkRowId;
        public Guid fkStockItemId;
        public String ProperyName;
        public String PropertyValue;
        public String PropertyType;
    }
}