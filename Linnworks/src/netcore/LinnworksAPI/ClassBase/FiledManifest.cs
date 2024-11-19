using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class FiledManifest : LinnObject
	{
		public Int32 ManifestId { get; set; }

		public Guid? ExternalManifestId { get; set; }

		public Int32 NumConsignments { get; set; }

		public DateTime Date { get; set; }

		public Boolean IsError { get; set; }

		public Boolean IsComplete { get; set; }

		public String Reference { get; set; }

		public String Vendor { get; set; }

		public String AccountId { get; set; }

		public Int32? fkShippingAPIConfigId { get; set; }
	} 
}