using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PackedItem
	{
		public Guid ID { get; set; }

		public Guid PkStockItemId { get; set; }

		public String SKU { get; set; }

		public Double Width { get; set; }

		public Double Height { get; set; }

		public Double Depth { get; set; }

		public Decimal Weight { get; set; }

		public Double X { get; set; }

		public Double Y { get; set; }

		public Double Z { get; set; }

		public Int32 Layer { get; set; }

		public IList<Face> Faces { get; set; }
	} 
}