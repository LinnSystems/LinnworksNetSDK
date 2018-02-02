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
		public DateTime? DateFrom;

        /// <summary>
        /// Date to 
        /// </summary>
		public DateTime? DateTo;

        /// <summary>
        /// Filter type 
        /// </summary>
		public DateTimeFieldFilterType Type;

        /// <summary>
        /// Filtering input 
        /// </summary>
		public Int32? Value;

		public FieldCode FieldCode;
	} 
}