using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemBatchAudit
	{
		public Int32 BatchId;

		public Int32 BatchInventoryId;

		public Int32 QuantityDelta;

		public Decimal StockValueDelta;

		public String ChangeNote;

		public String Username;

		public DateTime ChangeDate;

		public String BinRack;

		public String BatchNumber;

		public String Location;

		public Int32? fkJobId;

		public Int32? OrderId;
	} 
}