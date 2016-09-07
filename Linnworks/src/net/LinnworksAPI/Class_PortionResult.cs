using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class PortionResult<InventoryItem>
    {
        public List<InventoryItem> Items;
        public Int32 TotalItems;
        public Int32 StartIndex;
        public Guid Token;
    }
}