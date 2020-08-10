using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdatePickingWaveItemWithNewBinrackRequest
	{
        /// <summary>
        /// Pickwave id 
        /// </summary>
		public Int32 PickingWaveId;

        /// <summary>
        /// List of pickwave item row ids to replace with the new location 
        /// </summary>
		public List<Int32> PickingWaveItemRowIds;

        /// <summary>
        /// The new batch inventory to pick 
        /// </summary>
		public Int32 NewBatchInventoryId;

        /// <summary>
        /// Dictates how the returned pickwave should be sorted 
        /// </summary>
		public ItemUpdateSortType SortType;
	} 
}