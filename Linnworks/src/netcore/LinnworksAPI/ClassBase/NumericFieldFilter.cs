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
		public NumericFieldFilterType Type;

        /// <summary>
        /// Filtering input 
        /// </summary>
		public Double Value;

		public FieldCode FieldCode;
	} 
}