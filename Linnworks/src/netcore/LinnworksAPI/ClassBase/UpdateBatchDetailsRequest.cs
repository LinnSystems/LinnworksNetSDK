using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateBatchDetailsRequest
	{
		public Guid StockItemId;

		public Int32 InventoryTrackingType;

		public Boolean BatchNumberScanRequired;

		public Boolean? ResetBatchDates;
	} 
}