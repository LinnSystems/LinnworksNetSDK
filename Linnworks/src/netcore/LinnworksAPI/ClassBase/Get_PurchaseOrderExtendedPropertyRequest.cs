using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Get_PurchaseOrderExtendedPropertyRequest
	{
        /// <summary>
        /// Purchase Order unique identifier 
        /// </summary>
		public Guid PurchaseId { get; set; }
	} 
}