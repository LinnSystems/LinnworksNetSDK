using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ListFieldFilter
	{
        /// <summary>
        /// Filtering input 
        /// </summary>
		public String Value;

        /// <summary>
        /// Filter type 
        /// </summary>
		public ListFieldFilterType Type;

		public FieldCode FieldCode;
	} 
}