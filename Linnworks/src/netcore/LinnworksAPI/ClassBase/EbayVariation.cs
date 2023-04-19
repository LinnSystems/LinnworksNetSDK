using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EbayVariation : LinnObject
	{
		public Int32 CollisionNumber { get; set; }

		public Boolean IsLinked { get; set; }

		public Guid StockItemId { get; set; }

		public String Barcode { get; set; }

		public List<KeyValue> MultipleIdentifiers { get; set; }

		public String Title { get; set; }

		public String SKU { get; set; }

		public String ePID { get; set; }

		public Boolean? IsCatalogMatch { get; set; }

		public List<EbayAttribute> Attributes { get; set; }

		public String ErrorMesage { get; set; }

		public List<ImageData> Pictures { get; set; }

		public EbayPrices Price { get; set; }

		public Int32? LotSize { get; set; }
	} 
}