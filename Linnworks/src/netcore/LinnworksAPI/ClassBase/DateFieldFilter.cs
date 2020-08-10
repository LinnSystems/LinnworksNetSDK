using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DateFieldFilter
	{
        /// <summary>
        /// Date from 
        /// </summary>
		public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Date to 
        /// </summary>
		public DateTime? DateTo { get; set; }

        /// <summary>
        /// Filter type 
        /// </summary>
		public DateTimeFieldFilterType Type { get; set; }

        /// <summary>
        /// Filtering input 
        /// </summary>
		public Int32? Value { get; set; }

		public FieldCode FieldCode { get; set; }
	} 
}