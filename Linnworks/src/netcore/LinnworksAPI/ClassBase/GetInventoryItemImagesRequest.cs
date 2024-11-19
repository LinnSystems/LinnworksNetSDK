using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetInventoryItemImagesRequest : LinnObject
	{
        /// <summary>
        /// Conditional. If not provided, you must provide ItemNumber 
        /// </summary>
		public Guid InventoryItemId { get; set; }

        /// <summary>
        /// Conditional. if InventoryItemId is provided, ItemNumber will be ignored 
        /// </summary>
		public String ItemNumber { get; set; }
	} 
}