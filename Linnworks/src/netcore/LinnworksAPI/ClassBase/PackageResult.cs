using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PackageResult
	{
		public Guid PackagingId { get; set; }

		public Double Width { get; set; }

		public Double Height { get; set; }

		public Double Depth { get; set; }

		public Decimal ItemWeight { get; set; }

		public Decimal PackagingWeight { get; set; }

		public IList<Face> Faces { get; set; }

		public IList<PackedItem> Items { get; set; }

		public Int32 LayerCount { get; set; }

		public IDictionary<Int32,Face> LayerFace { get; set; }

		public Boolean IsManualPackage { get; set; }
	} 
}