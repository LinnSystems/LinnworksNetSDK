using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AmazonListing : LinnObject
	{
		public Guid TemplateId { get; set; }

		public Guid InventoryItemId { get; set; }

		public String VariationGroupName { get; set; }

		public Int32 Version { get; set; }

		public String MerchantName { get; set; }

		public Guid ConfigId { get; set; }

		public String ConfigName { get; set; }

		public String ProductURL { get; set; }

		public String ImageURL { get; set; }

		public String Title { get; set; }

		public String Description { get; set; }

		public String ASIN { get; set; }

		public String SKU { get; set; }

		public String Barcode { get; set; }

		public String BarcodeType { get; set; }

		public String TitleSource { get; set; }

		public Double Price { get; set; }

		public KeyValueGeneric<Guid,Double> BusinessPrice { get; set; }

		public Int32? Quantity { get; set; }

		public String Category { get; set; }

		public String SubType { get; set; }

		public List<AmazonBNode> BrowseNodes { get; set; }

		public List<AmazonAttribute> Attributes { get; set; }

		public List<AmazonAttribute> Pictures { get; set; }

		public Boolean UseMainItemImages { get; set; }

		public String VariationTheme { get; set; }

		public List<AmazonVariation> Variations { get; set; }

		public List<AmazonVariation> OldVariations { get; set; }

		public AmazonListingStatus Status { get; set; }

		public Boolean IsReadOnly { get; set; }

		public String ReportId { get; set; }

		public String ErrorMsg { get; set; }

		public List<String> MessageIds { get; set; }

		public List<String> ShipOptions { get; set; }

		public Boolean IsCatalog { get; set; }

		public String ConditionType { get; set; }

		public String ConditionNote { get; set; }

		public String LowestNewPriceFormated { get; set; }

		public Decimal? DecimalSalesRank { get; set; }

		public Boolean ToList { get; set; }

		public Int32 Matches { get; set; }

		public Boolean NoMatches { get; set; }

		public Byte Adjustments { get; set; }

		public Boolean IsReFeeded { get; set; }
	} 
}