using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PackageType
	{
		public Guid PackageTypeId;

		public Guid PackageGroupId;

		public String PackageTitle;

		public Double FromGramms;

		public Double ToGramms;

		public Double PackagingWeight;

		public Double PackagingCapacity;

		public Guid Rowguid;

		public Double Width;

		public Double Height;

		public Double Depth;
	} 
}