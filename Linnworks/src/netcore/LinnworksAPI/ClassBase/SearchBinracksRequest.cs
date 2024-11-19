using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SearchBinracksRequest : LinnObject
	{
        /// <summary>
        /// Bin rack search term. For example for PUT1.2.3878, bin rack search term PUT1 will yeild the result 
        /// </summary>
		public String BinRack { get; set; }

        /// <summary>
        /// Specific location id. Location must be Warehouse Managed location 
        /// </summary>
		public Guid LocationId { get; set; }

        /// <summary>
        /// Stock Item Id 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// List of types of bin racks, nullable. If not provided all binrack types will be searched 
        /// </summary>
		public List<Int32> BinRackTypeIds { get; set; }

		public Int32 PageNumber { get; set; }
	} 
}