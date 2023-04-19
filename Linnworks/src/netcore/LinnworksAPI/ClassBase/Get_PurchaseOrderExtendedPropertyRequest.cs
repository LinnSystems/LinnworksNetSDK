using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Get_PurchaseOrderExtendedPropertyRequest : LinnObject
	{
        /// <summary>
        /// Purchase Order unique identifier 
        /// </summary>
		public Guid PurchaseId { get; set; }
	} 
}