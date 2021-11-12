using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Order
{
    public class OrderItem
    {
        public OrderItem()
        {
            this.Options = new List<OrderItemOption>();
        }

        #region Settings
        /// <summary>
        /// Indicates if the PricePerUnit includes tax.
        /// </summary>
        public bool TaxCostInclusive { get; set; }

        /// <summary>
        /// If True Linnworks will not overwrite the tax percentage.
        /// </summary>
        public bool UseChannelTax { get; set; }

        /// <summary>
        /// Indicates if the order line is a service.
        /// </summary>
        public bool IsService { get; set; }
        #endregion Settings

        /// <summary>
        /// Unique per order line number. Any orders with non unique or duplicates
        /// will not be saved.
        /// </summary>
        public string OrderLineNumber { get; set; }

        /// <summary>
        /// SKU of the product (used for Mapping).
        /// </summary>
        public string SKU { get; set; }

        /// <summary>
        /// Individual price per unit.
        /// </summary>
        public decimal PricePerUnit { get; set; }

        /// <summary>
        /// Quantity.
        /// </summary>
        public int Qty { get; set; }

        /// <summary>
        /// Tax rate.
        /// </summary>
        public decimal TaxRate { get; set; }

        /// <summary>
        /// Percentage line discount.
        /// </summary>
        public decimal LinePercentDiscount { get; set; }

        /// <summary>
        /// Title of the product.
        /// </summary>
        public string ItemTitle { get; set; }

        /// <summary>
        /// Item options.
        /// </summary>
        public List<OrderItemOption> Options { get; set; }
    }
}