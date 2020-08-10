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
		public Boolean UseChannelTax { get; set; }

        /// <summary>
        /// Used when IsNew is false to update the order 
        /// </summary>
		public Guid pkOrderId { get; set; }

        /// <summary>
        /// When the order is saved it will try and link by SKU after trying by channel sku mapping. 
        /// </summary>
		public Boolean AutomaticallyLinkBySKU { get; set; }

        /// <summary>
        /// Used to determine the site of the order. 
        /// </summary>
		public String Site { get; set; }

        /// <summary>
        /// Match postal service method by name 
        /// </summary>
		public String MatchPostalServiceTag { get; set; }

        /// <summary>
        /// Postal service name used for saving new postal services 
        /// </summary>
		public String PostalServiceName { get; set; }

        /// <summary>
        /// Determines wither or not to save postal service if it does not exist 
        /// </summary>
		public Boolean SavePostalServiceIfNotExist { get; set; }

        /// <summary>
        /// Match payment method by name 
        /// </summary>
		public String MatchPaymentMethodTag { get; set; }

        /// <summary>
        /// Payment method name used for saving new payment methods 
        /// </summary>
		public String PaymentMethodName { get; set; }

        /// <summary>
        /// Determines wither or not to save payment methods if it does not exist 
        /// </summary>
		public Boolean SavePaymentMethodIfNotExist { get; set; }

        /// <summary>
        /// Overrides the mapping source for the channel for example if the Source is 'AMAZON FBA' MappingSource can be used to overried to 'AMAZON' 
        /// </summary>
		public String MappingSource { get; set; }

        /// <summary>
        /// State the order should be saved eg hold, parked, none 
        /// </summary>
		public OrderState OrderState { get; set; }

        /// <summary>
        /// Payment status of the order, eg Paid
        /// If Unpaid ChannelOrderAdapter.Save() will ensure order is PARKED 
        /// </summary>
		public PaymentStatus PaymentStatus { get; set; }

        /// <summary>
        /// List of order items 
        /// </summary>
		public List<ChannelOrderItem> OrderItems { get; set; }

        /// <summary>
        /// List of extended properties for the order 
        /// </summary>
		public List<ChannelOrderExtendedProperty> ExtendedProperties { get; set; }

        /// <summary>
        /// List of notes for the order 
        /// </summary>
		public List<ChannelOrderNote> Notes { get; set; }

        /// <summary>
        /// Source 
        /// </summary>
		public String Source { get; set; }

        /// <summary>
        /// SubSource 
        /// </summary>
		public String SubSource { get; set; }

        /// <summary>
        /// Channel buyer username / name 
        /// </summary>
		public String ChannelBuyerName { get; set; }

        /// <summary>
        /// Reference number, should be the same as the one used for despatches 
        /// </summary>
		public String ReferenceNumber { get; set; }

        /// <summary>
        /// External Reference 
        /// </summary>
		public String ExternalReference { get; set; }

        /// <summary>
        /// Secondary reference number 
        /// </summary>
		public String SecondaryReferenceNumber { get; set; }

        /// <summary>
        /// Currency of the order, if value is null, empty or white space it will default to UNK 
        /// </summary>
		public String Currency { get; set; }

        /// <summary>
        /// The currency conversion rate Sale/Base 
        /// </summary>
		public Double ConversionRate { get; set; }

        /// <summary>
        /// UTC recieved date/time of the order 
        /// </summary>
		public DateTime ReceivedDate { get; set; }

        /// <summary>
        /// UTC date/time the order should be despatched by 
        /// </summary>
		public DateTime DispatchBy { get; set; }

        /// <summary>
        /// Date the order was paid for 
        /// </summary>
		public DateTime PaidOn { get; set; }

        /// <summary>
        /// Postal service cost inclusive of tax after discount 
        /// </summary>
		public Double PostalServiceCost { get; set; }

        /// <summary>
        /// Tax percent for the postal service cost, eg 20 
        /// </summary>
		public Double PostalServiceTaxRate { get; set; }

        /// <summary>
        /// Discount percent for the postal service cost, this will not calculate down the postal service cost 
        /// </summary>
		public Double PostalServiceDiscount { get; set; }

        /// <summary>
        /// This represents the final discount applied to the order, as a value (not a percentage), after all item-level discounts are applied. It will be split evenly across all order items 
        /// </summary>
		public Double Discount { get; set; }

        /// <summary>
        /// The tax number of the buyer 
        /// </summary>
		public String BuyerTaxNumber { get; set; }

        /// <summary>
        /// This represents how the discount will be split between items and postage. For an expsanation of each opiton, see the enum documentation 
        /// </summary>
		public DiscountType DiscountType { get; set; }

        /// <summary>
        /// This represents if the discount is applied before or after tax 
        /// </summary>
		public DiscountTaxType DiscountTaxType { get; set; }

        /// <summary>
        /// The orders billing address 
        /// </summary>
		public ChannelAddress BillingAddress { get; set; }

        /// <summary>
        /// The order delivery address 
        /// </summary>
		public ChannelAddress DeliveryAddress { get; set; }

        /// <summary>
        /// Channel specified delivery start date (do not set where is not provided) 
        /// </summary>
		public DateTime DeliveryStartDate { get; set; }

        /// <summary>
        /// Channel specified delivery end date (do not set where is not provided) 
        /// </summary>
		public DateTime DeliveryEndDate { get; set; }

        /// <summary>
        /// Order identifier tags 
        /// </summary>
		public HashSet<String> OrderIdentifierTags { get; set; }

        /// <summary>
        /// Bool to re-save order 
        /// </summary>
		public Boolean ForceReSaveFulfilledOrder { get; set; }
	} 
}