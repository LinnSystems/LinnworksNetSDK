using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetBinRackSkusRequest : LinnObject
	{
        /// <summary>
        /// WMS BinRack Id 
        /// </summary>
		public Int32 BinRackId { get; set; }

        /// <summary>
        /// Detail level required in the response 
        /// </summary>
		public List<GetBinRackSkusDetailLevel> DetailLevel { get; set; }
	} 
}