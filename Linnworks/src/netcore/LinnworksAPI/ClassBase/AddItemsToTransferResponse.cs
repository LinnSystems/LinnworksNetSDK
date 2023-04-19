using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddItemsToTransferResponse : LinnObject
	{
		public List<WarehouseTransferItem> TransferItems { get; set; }
	} 
}