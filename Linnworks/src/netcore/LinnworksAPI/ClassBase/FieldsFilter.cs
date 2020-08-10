using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Fields filter 
    /// </summary>
    public class FieldsFilter
	{
        /// <summary>
        /// Text type field filters 
        /// </summary>
		public List<TextFieldFilter> TextFields { get; set; }

        /// <summary>
        /// Boolean type field filters 
        /// </summary>
		public List<BooleanFieldFilter> BooleanFields { get; set; }

        /// <summary>
        /// Numerical type field filters 
        /// </summary>
		public List<NumericFieldFilter> NumericFields { get; set; }

        /// <summary>
        /// Date type field filters 
        /// </summary>
		public List<DateFieldFilter> DateFields { get; set; }

        /// <summary>
        /// List type field filters 
        /// </summary>
		public List<ListFieldFilter> ListFields { get; set; }

		public List<FieldVisibility> FieldVisibility { get; set; }
	} 
}