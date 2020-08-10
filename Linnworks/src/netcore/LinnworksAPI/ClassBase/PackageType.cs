using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PackageType
	{
		public Guid PackageTypeId { get; set; }

		public Guid PackageGroupId { get; set; }

		public String PackageTitle { get; set; }

		public Double FromGramms { get; set; }

		public Double ToGramms { get; set; }

		public Double PackagingWeight { get; set; }

		public Double PackagingCapacity { get; set; }

		public Guid Rowguid { get; set; }

		public Double Width { get; set; }

		public Double Height { get; set; }

		public Double Depth { get; set; }
	} 
}