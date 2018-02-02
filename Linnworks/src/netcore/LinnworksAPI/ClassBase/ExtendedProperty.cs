using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ExtendedProperty
	{
        /// <summary>
        /// Record row ID 
        /// </summary>
		public Guid RowId;

        /// <summary>
        /// Extended property name 
        /// </summary>
		public String Name;

        /// <summary>
        /// Extended property value 
        /// </summary>
		public String Value;

        /// <summary>
        /// Extended property type 
        /// </summary>
		public String Type;
	} 
}