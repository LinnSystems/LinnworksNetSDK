using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EbayPrices : LinnObject
	{
		public Double StartPrice { get; set; }

		public Double ReservePrice { get; set; }

		public Double BINPrice { get; set; }

		public Double AutoAccept { get; set; }

		public Double AutoDecline { get; set; }

		public Double OriginalRetailPrice { get; set; }
	} 
}