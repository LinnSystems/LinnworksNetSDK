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
		public Guid StockItemId { get; set; }

        /// <summary>
        /// The location to get the batch information from 
        /// </summary>
		public Guid? StockLocationId { get; set; }

        /// <summary>
        /// Defines whether we should only return available items 
        /// </summary>
		public Boolean AvailableOnly { get; set; }

        /// <summary>
        /// Only return warehouse locations that can have orders assigned to them for picking 
        /// </summary>
		public Boolean AssignableOnly { get; set; }
	} 
}