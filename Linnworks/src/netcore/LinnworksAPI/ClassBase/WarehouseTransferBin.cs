using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseTransferBin
	{
        /// <summary>
        /// Bin ID 
        /// </summary>
		public Guid PkBinId;

        /// <summary>
        /// Transfer bin name 
        /// </summary>
		public String BinName;

        /// <summary>
        /// Bin reference 
        /// </summary>
		public String BinReference;

        /// <summary>
        /// Bin barcode 
        /// </summary>
		public String BinBarcode;

        /// <summary>
        /// List of transfer bin notes 
        /// </summary>
		public List<WarehouseTransferBinNote> BinNotes;

        /// <summary>
        /// List of transfer items 
        /// </summary>
		public List<WarehouseTransferItem> BinItems;
	} 
}