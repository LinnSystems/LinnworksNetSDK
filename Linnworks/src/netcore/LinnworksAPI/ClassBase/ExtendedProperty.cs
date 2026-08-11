using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ExtendedProperty : LinnObject
	{
        /// <summary>
        /// Record row ID 
        /// </summary>
		public Guid RowId { get; set; }

        /// <summary>
        /// Date the extended property was created 
        /// </summary>
		public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Date the extended property was last updated 
        /// </summary>
		public DateTime LastUpdatedDate { get; set; }

		public String Name { get; set; }

		public String Value { get; set; }

		public String Type { get; set; }
	} 
}