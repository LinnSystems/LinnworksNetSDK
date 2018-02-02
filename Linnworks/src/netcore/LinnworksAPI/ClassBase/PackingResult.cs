using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PackingResult
	{
		public Int32 TotalPackages;

		public IList<PackageResult> Packages;

		public IDictionary<Guid,Int32> UnpackedItems;
	} 
}