using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class InventoryParametersRequest
	{
        /// <summary>
        /// List of stock item ids 
        /// </summary>
		public List<Guid> InventoryItemIds;

        /// <summary>
        /// n/a 
        /// </summary>
		public List<Tuple<Int32,Int32>> SelectedRegions;

        /// <summary>
        /// n/a (can be ignored) 
        /// </summary>
		public Guid Token;
	} 
}