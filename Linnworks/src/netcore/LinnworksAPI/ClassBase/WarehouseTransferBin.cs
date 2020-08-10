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
		public Guid PkBinId { get; set; }

        /// <summary>
        /// Transfer bin name 
        /// </summary>
		public String BinName { get; set; }

        /// <summary>
        /// Bin reference 
        /// </summary>
		public String BinReference { get; set; }

        /// <summary>
        /// Bin barcode 
        /// </summary>
		public String BinBarcode { get; set; }

        /// <summary>
        /// List of transfer bin notes 
        /// </summary>
		public List<WarehouseTransferBinNote> BinNotes { get; set; }

        /// <summary>
        /// List of transfer items 
        /// </summary>
		public List<WarehouseTransferItem> BinItems { get; set; }
	} 
}