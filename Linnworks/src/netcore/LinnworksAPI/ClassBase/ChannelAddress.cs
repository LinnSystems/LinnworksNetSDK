using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChannelAddress
	{
		public String MatchCountryCode { get; set; }

		public String MatchCountryName { get; set; }

		public String FullName { get; set; }

		public String Company { get; set; }

		public String Address1 { get; set; }

		public String Address2 { get; set; }

		public String Address3 { get; set; }

		public String Town { get; set; }

		public String Region { get; set; }

		public String PostCode { get; set; }

		public String Country { get; set; }

		public String PhoneNumber { get; set; }

		public String EmailAddress { get; set; }

		public Boolean isEmpty { get; set; }
	} 
}