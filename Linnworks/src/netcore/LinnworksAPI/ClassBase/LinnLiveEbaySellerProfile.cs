using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class LinnLiveEbaySellerProfile : LinnObject
	{
		public Int64? ProfileId { get; set; }

		public String ProfileType { get; set; }

		public String ProfileName { get; set; }

		public String ErrorMessage { get; set; }

		public String SellerProfileExtendedProperty { get; set; }
	} 
}