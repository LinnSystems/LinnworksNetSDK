using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChannelOrder
	{
        /// <summary>
        /// Validate if the tax should be overwritten on the order. 
        /// </summary>
		public Boolean UseChannelTax;

        /// <summary>
        /// Used when IsNew is false to update the order 
        /// </summary>
		public Guid pkOrderId;

        /// <summary>
        /// When the order is saved it will try and link by SKU after trying by channel sku mapping. 
        /// </summary>
		public Boolean AutomaticallyLinkBySKU;

        /// <summary>
        /// Used to determine the site of the order. 
        /// </summary>
		public String Site;

        /// <summary>
        /// Match postal service method by name 
        /// </summary>
		public String MatchPostalServiceTag;

        /// <summary>
        /// Postal service name used for saving new postal services 
        /// </summary>
		public String PostalServiceName;

        /// <summary>
        /// Determines wither or not to save postal service if it does not exist 
        /// </summary>
		public Boolean SavePostalServiceIfNotExist;

        /// <summary>
        /// Match payment method by name 
        /// </summary>
		public String MatchPaymentMethodTag;

        /// <summary>
        /// Payment method name used for saving new payment methods 
        /// </summary>
		public String PaymentMethodName;

        /// <summary>
        /// Determines wither or not to save payment methods if it does not exist 
        /// </summary>
		public Boolean SavePaymentMethodIfNotExist;

        /// <summary>
        /// Overrides the mapping source for the channel for example if the Source is 'AMAZON FBA' MappingSource can be used to overried to 'AMAZON' 
        /// </summary>
		public String MappingSource;

        /// <summary>
        /// State the order should be saved eg hold, parked, none 
        /// </summary>
		public OrderState OrderState;

        /// <summary>
        /// Payment status of the order, eg Paid
        /// If Unpaid ChannelOrderAdapter.Save() will ensure order is PARKED 
        /// </summary>
		public PaymentStatus PaymentStatus;

        /// <summary>
        /// List of order items 
        /// </summary>
		public List<ChannelOrderItem> OrderItems;

        /// <summary>
        /// List of extended properties for the order 
        /// </summary>
		public List<ChannelOrderExtendedProperty> ExtendedProperties;

        /// <summary>
        /// List of notes for the order 
        /// </summary>
		public List<ChannelOrderNote> Notes;

        /// <summary>
        /// Source 
        /// </summary>
		public String Source;

        /// <summary>
        /// SubSource 
        /// </summary>
		public String SubSource;

        /// <summary>
        /// Channel buyer username / name 
        /// </summary>
		public String ChannelBuyerName;

        /// <summary>
        /// Reference number, should be the same as the one used for despatches 
        /// </summary>
		public String ReferenceNumber;

        /// <summary>
        /// External Reference 
        /// </summary>
		public String ExternalReference;

        /// <summary>
        /// Secondary reference number 
        /// </summary>
		public String SecondaryReferenceNumber;

        /// <summary>
        /// Currency of the order, if value is null, empty or white space it will default to UNK 
        /// </summary>
		public String Currency;

        /// <summary>
        /// The currency conversion rate Sale/Base 
        /// </summary>
		public Double ConversionRate;

        /// <summary>
        /// UTC recieved date/time of the order 
        /// </summary>
		public DateTime ReceivedDate;

        /// <summary>
        /// UTC date/time the order should be despatched by 
        /// </summary>
		public DateTime DispatchBy;

        /// <summary>
        /// Date the order was paid for 
        /// </summary>
		public DateTime PaidOn;

        /// <summary>
        /// Postal service cost inclusive of tax after discount 
        /// </summary>
		public Double PostalServiceCost;

        /// <summary>
        /// Tax percent for the postal service cost, eg 20 
        /// </summary>
		public Double PostalServiceTaxRate;

        /// <summary>
        /// Discount percent for the postal service cost, this will not calculate down the postal service cost 
        /// </summary>
		public Double PostalServiceDiscount;

        /// <summary>
        /// This represents the final discount applied to the order, as a value (not a percentage), after all item-level discounts are applied. It will be split evenly across all order items 
        /// </summary>
		public Double Discount;

        /// <summary>
        /// The tax number of the buyer 
        /// </summary>
		public String BuyerTaxNumber;

        /// <summary>
        /// This represents how the discount will be split between items and postage. For an expsanation of each opiton, see the enum documentation 
        /// </summary>
		public DiscountType DiscountType;

        /// <summary>
        /// This represents if the discount is applied before or after tax 
        /// </summary>
		public DiscountTaxType DiscountTaxType;

        /// <summary>
        /// The orders billing address 
        /// </summary>
		public ChannelAddress BillingAddress;

        /// <summary>
        /// The order delivery address 
        /// </summary>
		public ChannelAddress DeliveryAddress;

        /// <summary>
        /// Channel specified delivery start date (do not set where is not provided) 
        /// </summary>
		public DateTime DeliveryStartDate;

        /// <summary>
        /// Channel specified delivery end date (do not set where is not provided) 
        /// </summary>
		public DateTime DeliveryEndDate;

        /// <summary>
        /// Order identifier tags 
        /// </summary>
		public HashSet<String> OrderIdentifierTags;

        /// <summary>
        /// Bool to re-save order 
        /// </summary>
		public Boolean ForceReSaveFulfilledOrder;
	} 
}