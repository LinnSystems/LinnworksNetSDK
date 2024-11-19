using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EbayConfig : LinnObject
	{
		public Guid pkConfigId { get; set; }

		public String ConfigName { get; set; }

		public String EbayAccount { get; set; }

		public String Site { get; set; }

		public Guid OriginalConfigId { get; set; }

		public String OriginalSite { get; set; }

		public Boolean IsOutOfStockFeatureEnabled { get; set; }

		public Int32 MaxQuantity { get; set; }

		public Int32 MinQuantity { get; set; }

		public Int32 MaxQuantityPerBuyer { get; set; }

		public Boolean IsMaxQuantityPerBuyerEnabled { get; set; }

		public Boolean ShowInInventory { get; set; }

		public Int32 AssociatedTemplates { get; set; }

		public Int32 AssociatedVariations { get; set; }

		public String ListingType { get; set; }

		public String ListingDuration { get; set; }

		public String Currency { get; set; }

		public String ProductLocationCountry { get; set; }

		public String ProductLocation { get; set; }

		public String PostalCode { get; set; }

		public String ProductLocationCountryExtendedProperty { get; set; }

		public String ProductLocationExtendedProperty { get; set; }

		public String PostalCodeExtendedProperty { get; set; }

		public List<KeyValue> PaymentMethods { get; set; }

		public String PaypalEmail { get; set; }

		public Single CODCost { get; set; }

		public Boolean IsImmediatePaymentRequired { get; set; }

		public Boolean InStorePickup { get; set; }

		public Boolean SoldOneBay { get; set; }

		public KeyValue ReturnAccepted { get; set; }

		public KeyValue ReturnRefund { get; set; }

		public KeyValue ReturnPaidBy { get; set; }

		public KeyValue ReturnWithin { get; set; }

		public KeyValue RestockingFee { get; set; }

		public String ReturnPolicy { get; set; }

		public String AdditionalCheckoutInstructions { get; set; }

		public String Description { get; set; }

		public Boolean GlobalShippingProgram { get; set; }

		public Boolean PromotionalShippingDiscount { get; set; }

		public Boolean InternationalPromotionalShippingDiscount { get; set; }

		public Boolean DomesticShippingRateTable { get; set; }

		public Boolean InternationalShippingRateTable { get; set; }

		public String DomesticShippingProfileId { get; set; }

		public String InternationalShippingProfileId { get; set; }

		public String DomesticShippingProfileId_ExtendedProperty { get; set; }

		public String InternationalShippingProfileId_ExtendedProperty { get; set; }

		public KeyValue MaximumDispatchTime { get; set; }

		public String MaximumDispatchTime_ExtendedProperty { get; set; }

		public List<Shipping> DomesticShippings { get; set; }

		public List<Shipping> InternationalShippings { get; set; }

		public String FlatCalculatedShipping { get; set; }

		public String ShippingPackageType { get; set; }

		public List<String> ExcludedLocations { get; set; }

		public List<String> ShippingLocations { get; set; }

		public String FreeCalculatedShippingServiceId { get; set; }

		public Boolean IsExtendedPropertySplittable { get; set; }

		public Boolean IsAutoMappingExtPropToSpecEnabled { get; set; }

		public Boolean IsVariationSpecificationLimitIncreased { get; set; }

		public Boolean IsCatalog { get; set; }

		public Boolean IsPrivateListingEnabled { get; set; }

		public Boolean IsListInternationallyEnabled { get; set; }

		public Boolean IsBestOfferEnabled { get; set; }

		public Boolean IsTaxTableEnabled { get; set; }

		public Boolean IsVATEnabled { get; set; }

		public Double VAT { get; set; }

		public String VatExtendedProperty { get; set; }

		public List<LinnworksEbayCategory> Categories { get; set; }

		public List<LinnworksEbayCategory> StoreCategories { get; set; }

		public List<LinnworksEbayCategory> OldCategories { get; set; }

		public Boolean UseSuggestedCategory { get; set; }

		public Boolean AutoConvertCategories { get; set; }

		public String PrimaryCategory_ExtendedProperty { get; set; }

		public String SecondaryCategory_ExtendedProperty { get; set; }

		public String StorePrimaryCategory_ExtendedProperty { get; set; }

		public String StoreSecondaryCategory_ExtendedProperty { get; set; }

		public String VariationTitle_ExtendedProperty { get; set; }

		public KeyValue Condition { get; set; }

		public String Condition_ExtendedProperty { get; set; }

		public String ConditionNote_ExtendedProperty { get; set; }

		public String Barcode_ExtendedProperty { get; set; }

		public Boolean MultipleIdentifiersEnabled { get; set; }

		public List<String> MultipleProductIdentifiers { get; set; }

		public List<EbaySpecification> Specifications { get; set; }

		public List<EbaySpecification> Variations { get; set; }

		public Boolean DontUseVariationPictures { get; set; }

		public EbayPhotoDisplayCodeTypes PhotoDisplayCodeType { get; set; }

		public Boolean AutoSelectImages { get; set; }

		public String CharityOrganisationId { get; set; }

		public Double CharityDonationPercent { get; set; }

		public Int64 LastUpdateTime { get; set; }

		public String LastUpdateSessionId { get; set; }

		public EbaySellerProfile PaymentProfile { get; set; }

		public EbaySellerProfile ReturnProfile { get; set; }

		public EbaySellerProfile ShippingProfile { get; set; }

		public List<PickupLocationTime> PickupLocationTimes { get; set; }

		public Boolean IsConfiguratorEdited { get; set; }

		public Boolean IsMappingConfigurator { get; set; }

		public Boolean SchedulingEnabled { get; set; }

		public Boolean UseLotsEnabled { get; set; }

		public Boolean UseNewApi { get; set; }

		public String ChannelLocationIdentifier { get; set; }

		public String DimensionMeasure { get; set; }
	} 
}