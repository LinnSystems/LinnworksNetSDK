using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ChannelOrder
    {
        public Boolean UseChannelTax;
        public Boolean AutomaticallyLinkBySKU;
        public String Site;
        public String MatchPostalServiceTag;
        public String MatchPaymentMethodTag;
        public String MappingSource;
        public OrderState OrderState;
        public PaymentStatus PaymentStatus;
        public List<ChannelOrderItem> OrderItems;
        public List<ChannelOrderExtendedProperty> ExtendedProperties;
        public List<ChannelOrderNote> Notes;
        public String Source;
        public String SubSource;
        public String ChannelBuyerName;
        public String ReferenceNumber;
        public String ExternalReference;
        public String SecondaryReferenceNumber;
        public String Currency;
        public DateTime ReceivedDate;
        public DateTime DispatchBy;
        public DateTime PaidOn;
        public Double PostalServiceCost;
        public Double PostalServiceTaxRate;
        public Double PostalServiceDiscount;
        public Double Discount;
        public DiscountType DiscountType;
        public ChannelAddress BillingAddress;
        public ChannelAddress DeliveryAddress;
        public OrderXML OrderXML;
    }
}