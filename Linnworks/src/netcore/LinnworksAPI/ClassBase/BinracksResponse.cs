using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BinracksResponse
	{
        /// <summary>
        /// List of binracks available for the given item in the order applicability. 
        /// </summary>
		public List<WarehouseBinRack> BinRacks { get; set; }

		public List<String> Decisions { get; set; }
	} 
}