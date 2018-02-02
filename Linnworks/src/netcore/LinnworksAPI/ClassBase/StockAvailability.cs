using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockAvailability
	{
		public Guid PkId;

		public LevelType LevelType;

		public AvailabilityStatus Status;

		public String ReferenceNumber;

		public Int32 Quantity;
	} 
}