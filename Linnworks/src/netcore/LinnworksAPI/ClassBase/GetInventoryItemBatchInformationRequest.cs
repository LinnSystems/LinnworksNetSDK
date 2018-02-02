using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Used to get inventory item batch information 
    /// </summary>
    public class GetInventoryItemBatchInformationRequest
	{
        /// <summary>
        /// The item id 
        /// </summary>
		public Guid StockItemId;

        /// <summary>
        /// The location to get the batch information from 
        /// </summary>
		public Guid? StockLocationId;

        /// <summary>
        /// Defines whether we should only return available items 
        /// </summary>
		public Boolean AvailableOnly;
	} 
}