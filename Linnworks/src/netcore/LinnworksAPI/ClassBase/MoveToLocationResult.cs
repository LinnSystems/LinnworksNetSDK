using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class MoveToLocationResult
	{
        /// <summary>
        /// List of errors 
        /// </summary>
		public List<String> Errors { get; set; }

        /// <summary>
        /// List of orders that were moved 
        /// </summary>
		public List<Guid> OrdersMoved { get; set; }
	} 
}