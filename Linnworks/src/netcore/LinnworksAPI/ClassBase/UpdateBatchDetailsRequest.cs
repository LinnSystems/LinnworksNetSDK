using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateBatchDetailsRequest
	{
		public Guid StockItemId { get; set; }

		public Int32 InventoryTrackingType { get; set; }

		public Boolean BatchNumberScanRequired { get; set; }

		public Boolean? ResetBatchDates { get; set; }
	} 
}