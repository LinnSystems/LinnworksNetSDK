using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EbayWeightRule : LinnObject
	{
		public Boolean Disabled { get; set; }

		public Double? FromWeight { get; set; }

		public Double? ToWeight { get; set; }

		public Double? Price { get; set; }

		public Double? AdditionalPrice { get; set; }

		public Boolean IsFirst { get; set; }
	} 
}