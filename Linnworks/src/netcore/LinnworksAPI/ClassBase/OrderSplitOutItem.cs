using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderSplitOutItem : LinnObject
	{
		public Guid RowId { get; set; }

		public Int32 Quantity { get; set; }

		public Double Weight { get; set; }

		public Double UnitCost { get; set; }
	} 
}