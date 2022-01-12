using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddExtendedPropertiesRequest
	{
        /// <summary>
        /// Order id of the order to append extended properties to 
        /// </summary>
		public Guid OrderId { get; set; }

        /// <summary>
        /// Array of basic extended properties to be added 
        /// </summary>
		public BasicExtendedProperty[] ExtendedProperties { get; set; }
	} 
}