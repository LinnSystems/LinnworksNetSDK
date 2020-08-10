using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PackingResult
	{
		public Int32 TotalPackages { get; set; }

		public IList<PackageResult> Packages { get; set; }

		public IDictionary<Guid,Int32> UnpackedItems { get; set; }
	} 
}