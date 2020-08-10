using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class TextFieldFilter
	{
        /// <summary>
        /// Filter type 
        /// </summary>
		public TextFieldFilterType Type { get; set; }

        /// <summary>
        /// Filtering input 
        /// </summary>
		public String Text { get; set; }

		public FieldCode FieldCode { get; set; }
	} 
}