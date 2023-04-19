using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EbayShipping : LinnObject
	{
		public LinnLiveEbayShippingService ShippingService { get; set; }

		public Double? Price { get; set; }

		public String Price_ExtendedProperty { get; set; }

		public Double? AdditionalPrice { get; set; }

		public String AdditionalPrice_ExtendedProperty { get; set; }

		public Double? HandlingPrice { get; set; }

		public List<LinnLiveKeyValue> ShippingLocations { get; set; }

		public List<LinnLiveEbayWeightRule> WeightRules { get; set; }

		public List<LinnLiveEbayPriceRule> PriceAssociationRules { get; set; }
	} 
}