using System;

namespace LinnworksAPI
{
    public class StockItemChangeHistory
    {
        public DateTime Date;
        public Int32 Level;
        public Double StockValue;
        public String Note;
        public Int32 ChangeQty;
        public Double ChangeValue;
        public Guid StockItemId;
    }
}