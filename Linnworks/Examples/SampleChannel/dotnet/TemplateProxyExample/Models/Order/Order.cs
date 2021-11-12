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

        /// <summary>
        /// Billing Address <see cref="Address"/>.
        /// </summary>
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Delivery Address <see cref="Address"/>.
        /// </summary>
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// Order items <see cref="OrderItem"/>.
        /// </summary>
        public List<OrderItem> OrderItems { get; set; }

        /// <summary>
        /// Extended properties <see cref="OrderExtendedProperty"/>.
        /// </summary>
        public List<OrderExtendedProperty> ExtendedProperties { get; set; }

        /// <summary>
        /// Notes <see cref="OrderNote"/>.
        /// </summary>
        public List<OrderNote> Notes { get; set; }

        #region MatchFields

        /// <summary>
        /// Site of the order, this is usually used when the channel has one set of credentials
        /// however has multiple sites for example UK, DE, US and so on. Leave blank if this is
        /// not applicable. This field is used in Postal Service and Payment mapping.
        /// </summary>
        public string Site { get; set; }

        /// <summary>
        /// Shipping tag used which is used for order mapping to map the channel shipping tag
        /// to the Linnworks shipping service.
        /// </summary>
        public string MatchPostalServiceTag { get; set; }

        /// <summary>
        /// Payment tag used which is used for order mapping to map the channel payment tag to
        /// the Linnworks payment service.
        /// </summary>
        public string MatchPaymentMethodTag { get; set; }
        #endregion MatchFields

        /// <summary>
        /// Payment status of the order <see cref="Models.Order.PaymentStatus"/>.
        /// </summary>
        public PaymentStatus PaymentStatus { get; set; }

        /// <summary>
        /// Name of the customer who bought the item. If the channel supports usernames it’s
        /// suggested to put the username instead of the actual name of the customer.
        /// </summary>
        public string ChannelBuyerName { get; set; }

        /// <summary>
        /// Unique reference of the order. If two orders have the same reference then one will
        /// be ignored. This field will be sent back when marking orders as despatched.
        /// </summary>
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// External reference is usually the payment gateway transaction id.
        /// </summary>
        public string ExternalReference { get; set; }

        public string SecondaryReferenceNumber { get; set; }

        /// <summary>
        /// 3 digit ISO 4217 currency code of the order.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Date the order was created. Where possible normalize to UTC Format: ​"yyyy-MM-dd HH:mm:ssZ".
        /// </summary>
        public DateTime ReceivedDate { get; set; }

        /// <summary>
        /// Date the order should be shipped by. Where possible normalize to UTC Format: ​"yyyy-MM-dd HH:mm:ssZ".
        /// </summary>
        public DateTime DispatchBy { get; set; }

        /// <summary>
        /// Date the order was paid. Where possible normalize to UTC Format: ​"yyyy-MM-dd HH:mm:ssZ".
        /// </summary>
        public DateTime PaidOn { get; set; }

        /// <summary>
        /// Postal cost of the order including tax.
        /// </summary>
        public decimal PostalServiceCost { get; set; }

        /// <summary>
        /// Tax rate used for the postal service.
        /// </summary>
        public decimal PostalServiceTaxRate { get; set; }

        /// <summary>
        /// The discount type <see cref="Models.Order.DiscountType"/>.
        /// </summary>
        public DiscountType DiscountType { get; set; }

        /// <summary>
        /// The discount ammount.
        /// </summary>
        public double Discount { get; set; }
    }
}
