using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EbayListing : LinnObject
	{
		public Boolean IsCreatedWithMappingTool { get; set; }

		public Guid TemplateId { get; set; }

		public Guid InventoryItemId { get; set; }

		public String VariationGroupName { get; set; }

		public Guid ConfigId { get; set; }

		public String ConfigName { get; set; }

		public List<String> ListingIds { get; set; }

		public String SKU { get; set; }

		public String AccountId { get; set; }

		public String Barcode { get; set; }

		public String BarcodeErrorMessage { get; set; }

		public List<KeyValue> MultipleIdentifiers { get; set; }

		public EbayPrices Price { get; set; }

		public Int32 AvailableQuantity { get; set; }

		public String Title { get; set; }

		public String SubTitle { get; set; }

		public String Description { get; set; }

		public String ePID { get; set; }

		public Boolean IsCatalogMatch { get; set; }

		public Boolean? IsProductRequired { get; set; }

		public List<EbayAttribute> Attributes { get; set; }

		public List<ImageData> Pictures { get; set; }

		public List<LinnworksEbayCategory> Categories { get; set; }

		public List<LinnworksEbayCategory> StoreCategories { get; set; }

		public Boolean DontUseVariationPictures { get; set; }

		public String VariationPictureSpecific { get; set; }

		public List<EbayVariation> Variations { get; set; }

		public List<KeyList> VariationsPositions { get; set; }

		public List<EbayVariation> OldVariations { get; set; }

		public List<KeyList> OldVariationSpecifics { get; set; }

		public Boolean IsProductConfirmationRequired { get; set; }

		public EbayListingStatus Status { get; set; }

		public String ErrorMessage { get; set; }

		public Byte Adjustments { get; set; }

		public String TitleSource { get; set; }

		public Boolean IsPendingRelist { get; set; }

		public DateTime? StartTime { get; set; }

		public Boolean IsReadOnly { get; set; }

		public Boolean IsVirtualTemplate { get; set; }

		public String Site { get; set; }

		public String Currency { get; set; }

		public Boolean UseSuggestedCategory { get; set; }

		public Boolean AllowCategoryChange { get; set; }

		public Int32? LotSize { get; set; }

		public Boolean IsRecommendation { get; set; }

		public String RecommendationMessage { get; set; }

		public Boolean UseNewApi { get; set; }
	} 
}