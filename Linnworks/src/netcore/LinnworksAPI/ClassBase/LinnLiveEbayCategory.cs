using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class LinnLiveEbayCategory : LinnObject
	{
		public Boolean IsDefault { get; set; }

		public Boolean LotSizeDisabled { get; set; }

		public Boolean? IsProductRequired { get; set; }

		public Boolean? VariationsEnabled { get; set; }

		public Boolean? SiteSupported { get; set; }

		public String CategoryId { get; set; }

		public String CategoryName { get; set; }
	} 
}