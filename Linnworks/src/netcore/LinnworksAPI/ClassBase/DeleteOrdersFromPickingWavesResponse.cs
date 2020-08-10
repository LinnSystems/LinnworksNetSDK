using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteOrdersFromPickingWavesResponse
	{
        /// <summary>
        /// Order Ids that had pickwaves deleted from them 
        /// </summary>
		public IEnumerable<Int32> ProcessedOrderIds { get; set; }

        /// <summary>
        /// OrderIds where there was no pickwave found against them 
        /// </summary>
		public IEnumerable<Int32> NoPickwaves { get; set; }
	} 
}