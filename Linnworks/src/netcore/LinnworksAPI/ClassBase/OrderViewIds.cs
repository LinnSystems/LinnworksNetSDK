using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderViewIds
	{
		public Int32 ViewId { get; set; }

		public Guid LocationId { get; set; }

		public Int64 TotalOrders { get; set; }

		public Guid[] OrderIds { get; set; }

		public Int64 Count { get; set; }
	} 
}