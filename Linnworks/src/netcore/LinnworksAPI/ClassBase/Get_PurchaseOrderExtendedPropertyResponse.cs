using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Get_PurchaseOrderExtendedPropertyResponse
	{
        /// <summary>
        /// Purchase order extended properties 
        /// </summary>
		public List<PurchaseOrderExtendedProperty> Items { get; set; }
	} 
}