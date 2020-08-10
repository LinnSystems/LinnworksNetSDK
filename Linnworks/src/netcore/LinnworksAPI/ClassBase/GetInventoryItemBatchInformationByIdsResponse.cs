using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetInventoryItemBatchInformationByIdsResponse
	{
        /// <summary>
        /// A list of stock item batch data 
        /// </summary>
		public List<BatchInformation> InventoryItemBatchInformation { get; set; }
	} 
}