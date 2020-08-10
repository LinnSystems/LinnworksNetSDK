using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemBatchAudit
	{
		public Int32 BatchId { get; set; }

		public Int32 BatchInventoryId { get; set; }

		public Int32 QuantityDelta { get; set; }

		public Decimal StockValueDelta { get; set; }

		public String ChangeNote { get; set; }

		public String Username { get; set; }

		public DateTime ChangeDate { get; set; }

		public String BinRack { get; set; }

		public String BatchNumber { get; set; }

		public String Location { get; set; }

		public Int32? fkJobId { get; set; }

		public Int32? OrderId { get; set; }
	} 
}