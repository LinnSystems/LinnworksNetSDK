using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Order
{
    public class Order
    {
        public Order()
        {
            this.BillingAddress = new Address();
            this.DeliveryAddress = new Address();
            this.OrderItems = new List<OrderItem>();
            this.Notes = new List<OrderNote>();
            this.ExtendedProperties = new List<OrderExtendedProperty>();
        }

        public Address BillingAddress { get; set; }
        public Address DeliveryAddress { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public List<OrderExtendedProperty> ExtendedProperties { get; set; }
        public List<OrderNote> Notes { get; set; }

        #region MatchFields
        public string Site { get; set; }
        public string MatchPostalServiceTag { get; set; }
        public string MatchPaymentMethodTag { get; set; }
        #endregion MatchFields

        public PaymentStatus PaymentStatus { get; set; }
        public string ChannelBuyerName { get; set; }
        public string ReferenceNumber { get; set; }
        public string ExternalReference { get; set; }
        public string SecondaryReferenceNumber { get; set; }
        public string Currency { get; set; }
        public DateTime ReceivedDate { get; set; }
        public DateTime DispatchBy { get; set; }
        public DateTime PaidOn { get; set; }
        public decimal PostalServiceCost { get; set; }
        public decimal PostalServiceTaxRate { get; set; }
    }
}