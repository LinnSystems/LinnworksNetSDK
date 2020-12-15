using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickingWaveGenerateItemMulti
	{
        /// <summary>
        /// Order item row id 
        /// </summary>
		public Guid OrderItemRowId { get; set; }

        /// <summary>
        /// Batch inventory id, if the item is batched or location is warehouse managed and id is not supplied then the whole order item will be added to the pickwave. 
        /// </summary>
		public Int32? BatchInventoryId { get; set; }
	} 
}