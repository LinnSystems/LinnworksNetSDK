using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class System_ShippingAPI_Config : LinnObject
	{
		public Int32 pkShippingAPIConfigId { get; set; }

		public String Vendor { get; set; }

		public String VendorFriendlyName { get; set; }

		public String VendorIcon { get; set; }

		public String AccountId { get; set; }

		public String LabelFormat { get; set; }

		public Int32 Services { get; set; }

		public Boolean ManifestPending { get; set; }

		public Int32? LastManifestWithErrorId { get; set; }

		public Boolean ReadOnly { get; set; }

		public String Status { get; set; }

		public PrinterConfig PrinterConfig { get; set; }

		public Boolean? QuoteEnabled { get; set; }

		public Boolean QuoteOnlyIncludedServices { get; set; }
	} 
}