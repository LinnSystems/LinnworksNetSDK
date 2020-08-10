using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderExtendedProperty
	{
        /// <summary>
        /// Extended property record row ID 
        /// </summary>
		public Guid rowid { get; set; }

        /// <summary>
        /// Property name 
        /// </summary>
		public String PropertyName { get; set; }

        /// <summary>
        /// Property value 
        /// </summary>
		public String PropertyValue { get; set; }

        /// <summary>
        /// Property type 
        /// </summary>
		public String PropertyType { get; set; }
	} 
}