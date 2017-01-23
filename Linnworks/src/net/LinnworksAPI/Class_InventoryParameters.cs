using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class InventoryParameters
    {
        public List<Guid> InventoryItemIds;
        public List<Tuple<Int32, Int32>> SelectedRegions;
        public Guid Token;
    }
}