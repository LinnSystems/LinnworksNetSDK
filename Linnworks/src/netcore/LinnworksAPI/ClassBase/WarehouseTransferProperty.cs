using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseTransferProperty
	{
		public Guid PkTransferPropertyId { get; set; }

		public String TransferPropertyName { get; set; }

		public String TransferPropertyValue { get; set; }
	} 
}