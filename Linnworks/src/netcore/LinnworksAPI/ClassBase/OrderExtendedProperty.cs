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
		public Guid rowid;

        /// <summary>
        /// Property name 
        /// </summary>
		public String PropertyName;

        /// <summary>
        /// Property value 
        /// </summary>
		public String PropertyValue;

        /// <summary>
        /// Property type 
        /// </summary>
		public String PropertyType;
	} 
}