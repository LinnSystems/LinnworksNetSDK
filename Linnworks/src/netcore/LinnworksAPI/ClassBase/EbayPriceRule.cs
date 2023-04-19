using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EbayPriceRule : LinnObject
	{
		public Double? FromPrice { get; set; }

		public Double? ToPrice { get; set; }
	} 
}