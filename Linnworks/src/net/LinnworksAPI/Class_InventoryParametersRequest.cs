using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class InventoryParametersRequest
    {
        public List<Guid> InventoryItemIds;
        public List<Tuple<Int32, Int32>> SelectedRegions;
        public Guid Token;
    }
}