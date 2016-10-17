using System;

namespace LinnworksAPI
{
    public class CalcOrderItem
    {
        public Guid fkStockItemId;
        public Guid fkOrderItemId;
        public String SKU;
        public Int32 nQty;
        public Double ItemWeight;
        public Double DimHeight;
        public Double DimWidth;
        public Double DimDepth;
        public Guid PackageGroup;
        public Guid? fkCompositeParentRowId;
    }
}