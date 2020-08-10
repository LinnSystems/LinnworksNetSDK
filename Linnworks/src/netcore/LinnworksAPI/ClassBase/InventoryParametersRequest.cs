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
		public List<Guid> InventoryItemIds { get; set; }

        /// <summary>
        /// A list of row numbers for items selected in the my inventory grid. 
        /// For instance if the first entry in the list is 4, 4; the selection was from the fourth row, to the fourth row. 
        /// </summary>
		public List<Tuple<Int32,Int32>> SelectedRegions { get; set; }

        /// <summary>
        /// An internal token used to identify the list of inventory items within a certain view.
        /// From this, the inventory item ids can be extracted with the selected regions. 
        /// </summary>
		public Guid Token { get; set; }
	} 
}