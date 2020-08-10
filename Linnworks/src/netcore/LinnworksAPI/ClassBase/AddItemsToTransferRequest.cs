using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddItemsToTransferRequest
	{
		public Guid TransferId { get; set; }

		public List<WarehouseTransferItemQuantity> TransferItems { get; set; }
	} 
}