using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseTransferItemQuantity
	{
        /// <summary>
        /// Stock item ID (unique identifier) 
        /// </summary>
		public Guid fkStockItemId;

        /// <summary>
        /// Item request quantity 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// Transfer item ID (unique identifier) 
        /// </summary>
		public Guid pkTransferItemId;
	} 
}