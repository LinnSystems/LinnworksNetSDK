using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class LinkedItem
	{
        /// <summary>
        /// Country ID 
        /// </summary>
		public Guid pkStockId;

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String ItemNumber;

        /// <summary>
        /// Product title 
        /// </summary>
		public String ItemName;
	} 
}