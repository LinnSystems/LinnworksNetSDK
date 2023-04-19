using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class TrackingURLResponseItem : LinnObject
	{
		public String TrackingURL { get; set; }

		public Int32 OrderId { get; set; }

		public String Vendor { get; set; }

		public String PostalTrackingNumber { get; set; }

		public String Postcode { get; set; }
	} 
}