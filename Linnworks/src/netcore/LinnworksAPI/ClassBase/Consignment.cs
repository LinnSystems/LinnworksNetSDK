using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Consignment : LinnObject
	{
		public Int32 ConsignmentId { get; set; }

		public Int32 OrderId { get; set; }

		public String Customer { get; set; }

		public String Email { get; set; }

		public String PostalCode { get; set; }

		public String Country { get; set; }

		public Decimal Weight { get; set; }

		public List<String> TrackingNumbers { get; set; }

		public Int32 Packages { get; set; }

		public ManifestPackage[] ConsignmentPackages { get; set; }

		public ServiceProperty[] Properties { get; set; }

		public Boolean Deferred { get; set; }

		public String Service { get; set; }
	} 
}