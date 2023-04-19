using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class MoveToLocationResult : LinnObject
	{
        /// <summary>
        /// List of errors 
        /// </summary>
		public List<String> Errors { get; set; }

        /// <summary>
        /// List of orders that were moved 
        /// </summary>
		public List<Guid> OrdersMoved { get; set; }

        /// <summary>
        /// Dictionary of keyed errors. These are the same errors as per the Errors property, but indexable by orderId 
        /// </summary>
		public Dictionary<Guid,String> KeyedErrors { get; set; }
	} 
}