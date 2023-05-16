using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreatePOsFromInventoryRequest : LinnObject
	{
        /// <summary>
        /// A list of items that should either be added to a PO, either new or existing, depending on data 
        /// </summary>
		public List<MyInventoryPOCreationItems> ToCreate { get; set; }

        /// <summary>
        /// Linnworks stock location id 
        /// </summary>
		public Guid LocationId { get; set; }
	} 
}