using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Shipping : LinnObject
	{
		public EbayShippingService ShippingService { get; set; }

		public Double? Price { get; set; }

		public String Price_ExtendedProperty { get; set; }

		public Double? AdditionalPrice { get; set; }

		public String AdditionalPrice_ExtendedProperty { get; set; }

		public Double? HandlingPrice { get; set; }

		public List<KeyValue> ShippingLocations { get; set; }

		public List<EbayWeightRule> WeightRules { get; set; }

		public List<EbayPriceRule> PriceAssociationRules { get; set; }
	} 
}