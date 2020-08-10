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
		public Guid PkTransferItemId { get; set; }

        /// <summary>
        /// Stock item ID (unique identifier) 
        /// </summary>
		public Guid FkStockItemId { get; set; }

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// Product barcode 
        /// </summary>
		public String Barcode { get; set; }

        /// <summary>
        /// Product title 
        /// </summary>
		public String ItemTitle { get; set; }

        /// <summary>
        /// Quantity requested for transfer 
        /// </summary>
		public Int32 RequestedQuantity { get; set; }

        /// <summary>
        /// Quantity transferred 
        /// </summary>
		public Int32 SentQuantity { get; set; }

        /// <summary>
        /// Quantity received 
        /// </summary>
		public Int32? ReceivedQuantity { get; set; }

        /// <summary>
        /// Quantity from location 
        /// </summary>
		public Int32 InFromLocationQuantity { get; set; }

        /// <summary>
        /// Due from location quantity 
        /// </summary>
		public Int32 DueFromLocationQuantity { get; set; }

        /// <summary>
        /// Currently in location quantity 
        /// </summary>
		public Int32 InToLocationQuantity { get; set; }

        /// <summary>
        /// Items notes count 
        /// </summary>
		public Int32 ItemNoteCount { get; set; }

        /// <summary>
        /// Stock item binrack 
        /// </summary>
		public String BinRackNumber { get; set; }

        /// <summary>
        /// Transfer bin ID 
        /// </summary>
		public Guid PkBinId { get; set; }

        /// <summary>
        /// List of transfer notes 
        /// </summary>
		public List<WarehouseTransferItemNote> ItemNotes { get; set; }
	} 
}