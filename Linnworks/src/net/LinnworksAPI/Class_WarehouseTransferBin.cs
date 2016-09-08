using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class WarehouseTransferBin
    {
        public Guid PkBinId;
        public String BinName;
        public String BinReference;
        public String BinBarcode;
        public List<WarehouseTransferBinNote> BinNotes;
        public List<WarehouseTransferItem> BinItems;
    }
}