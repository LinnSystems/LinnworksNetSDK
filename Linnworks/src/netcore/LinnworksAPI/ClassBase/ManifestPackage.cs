using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ManifestPackage : LinnObject
	{
		public String OrderReference { get; set; }

		public Int32 PackageSeqNo { get; set; }

		public Decimal Weight { get; set; }

		public Decimal Depth { get; set; }

		public Decimal Width { get; set; }

		public Decimal Height { get; set; }

		public String PackageFormat { get; set; }

		public String TrackingNumber { get; set; }

		public Decimal Value { get; set; }

		public SavedItem[] Items { get; set; }
	} 
}