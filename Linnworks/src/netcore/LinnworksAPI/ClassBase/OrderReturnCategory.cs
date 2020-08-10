using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Return category object 
    /// </summary>
    public class OrderReturnCategory
	{
        /// <summary>
        /// Stock item ID 
        /// </summary>
		public Int32 pkItemId { get; set; }

        /// <summary>
        /// Category name 
        /// </summary>
		public String CategoryName { get; set; }
	} 
}