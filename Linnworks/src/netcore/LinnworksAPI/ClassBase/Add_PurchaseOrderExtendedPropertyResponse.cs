using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Add_PurchaseOrderExtendedPropertyResponse : LinnObject
	{
        /// <summary>
        /// Added purchase order extended properties 
        /// </summary>
		public List<PurchaseOrderExtendedProperty> Items { get; set; }
	} 
}