using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AmazonVariation : LinnObject
	{
		public Boolean IsIgnored { get; set; }

		public String IgnoredMsg { get; set; }

		public Int32 CollisionNumber { get; set; }

		public Guid StockItemId { get; set; }

		public String SKU { get; set; }

		public String Title { get; set; }

		public String Barcode { get; set; }

		public Double Price { get; set; }

		public KeyValueGeneric<Guid,Double> BusinessPrice { get; set; }

		public Int32? Quantity { get; set; }

		public List<AmazonAttribute> Pictures { get; set; }

		public List<AmazonAttribute> Attributes { get; set; }

		public List<String> MessageIds { get; set; }
	} 
}