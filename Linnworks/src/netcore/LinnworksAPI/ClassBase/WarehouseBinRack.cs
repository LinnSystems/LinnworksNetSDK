using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseBinRack
	{
		public Int32 BinRackId;

		public Int32 BinRackTypeId;

		public String BinRack;

		public GeoPosition GeoPosition;

		public Dimension Dimension;

		public Int32 RoutingSequence;

		public Decimal MaxCapacityVolumetric;

		public Decimal CurrentFullPercentage;

		public Int32 MaxQuantityCapacity;

		public Int32 CurrentQuantity;

		public Decimal CurrentVolumetric;

		public Decimal OptimalReplenishFullPercentage;

		public Decimal CriticalReplenishFullPercentage;

		public Boolean ItemRestriction;

		public Boolean GroupRestriction;

		public Guid LocationId;

		public String TypeName;

		public Int32 StandardType;

		public String AccessOrientation;
	} 
}