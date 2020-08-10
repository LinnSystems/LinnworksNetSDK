using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickingWaveGenerateOrder
	{
        /// <summary>
        /// Order Id (Integer) 
        /// </summary>
		public Int32 OrderId;

		public List<PickingWaveGenerateOrderItem> Items;
	} 
}