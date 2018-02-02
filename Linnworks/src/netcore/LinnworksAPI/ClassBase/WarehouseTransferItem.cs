using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseTransferItem
	{
        /// <summary>
        /// Transfer ID 
        /// </summary>
		public Guid PkTransferItemId;

        /// <summary>
        /// Stock item ID (unique identifier) 
        /// </summary>
		public Guid FkStockItemId;

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU;

        /// <summary>
        /// Product barcode 
        /// </summary>
		public String Barcode;

        /// <summary>
        /// Product title 
        /// </summary>
		public String ItemTitle;

        /// <summary>
        /// Quantity requested for transfer 
        /// </summary>
		public Int32 RequestedQuantity;

        /// <summary>
        /// Quantity transferred 
        /// </summary>
		public Int32 SentQuantity;

        /// <summary>
        /// Quantity received 
        /// </summary>
		public Int32? ReceivedQuantity;

        /// <summary>
        /// Quantity from location 
        /// </summary>
		public Int32 InFromLocationQuantity;

        /// <summary>
        /// Due from location quantity 
        /// </summary>
		public Int32 DueFromLocationQuantity;

        /// <summary>
        /// Currently in location quantity 
        /// </summary>
		public Int32 InToLocationQuantity;

        /// <summary>
        /// Items notes count 
        /// </summary>
		public Int32 ItemNoteCount;

        /// <summary>
        /// Stock item binrack 
        /// </summary>
		public String BinRackNumber;

        /// <summary>
        /// Transfer bin ID 
        /// </summary>
		public Guid PkBinId;

        /// <summary>
        /// List of transfer notes 
        /// </summary>
		public List<WarehouseTransferItemNote> ItemNotes;
	} 
}