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
		public String Value { get; set; }

        /// <summary>
        /// Filter type 
        /// </summary>
		public ListFieldFilterType Type { get; set; }

		public FieldCode FieldCode { get; set; }
	} 
}