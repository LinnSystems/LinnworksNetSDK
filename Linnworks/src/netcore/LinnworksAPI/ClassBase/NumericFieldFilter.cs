using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class NumericFieldFilter
	{
        /// <summary>
        /// Filter type 
        /// </summary>
		public NumericFieldFilterType Type { get; set; }

        /// <summary>
        /// Filtering input 
        /// </summary>
		public Double Value { get; set; }

		public FieldCode FieldCode { get; set; }
	} 
}