using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockAvailability
	{
		public Guid PkId { get; set; }

		public LevelType LevelType { get; set; }

		public AvailabilityStatus Status { get; set; }

		public String ReferenceNumber { get; set; }

		public Int32 Quantity { get; set; }
	} 
}