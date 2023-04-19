using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class LinnLiveEbayListing : LinnObject
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

		public List<LinnLiveKeyValue> MultipleIdentifiers { get; set; }

		public LinnLiveEbayPrices Price { get; set; }

		public Int32 AvailableQuantity { get; set; }

		public String Title { get; set; }

		public String SubTitle { get; set; }

		public String Description { get; set; }

		public String ePID { get; set; }

		public Boolean IsCatalogMatch { get; set; }

		public Boolean? IsProductRequired { get; set; }

		public List<LinnLiveEbayAttribute> Attributes { get; set; }

		public List<EbayImageData> Pictures { get; set; }

		public List<LinnLiveEbayCategory> Categories { get; set; }

		public List<LinnLiveEbayCategory> StoreCategories { get; set; }

		public Boolean DontUseVariationPictures { get; set; }

		public String VariationPictureSpecific { get; set; }

		public List<LinnLiveEbayVariation> Variations { get; set; }

		public List<LinnLiveKeyList> VariationsPositions { get; set; }

		public List<LinnLiveEbayVariation> OldVariations { get; set; }

		public List<LinnLiveKeyList> OldVariationSpecifics { get; set; }

		public Boolean IsProductConfirmationRequired { get; set; }

		public LinnLiveEbayListingStatus Status { get; set; }

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