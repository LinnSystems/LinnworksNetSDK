using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PickingWaveGenerateOrder : LinnObject
	{
        /// <summary>
        /// Order Id (Integer) 
        /// </summary>
		public Int32 OrderId { get; set; }

		public Int32 SortOrder { get; set; }
	} 
}