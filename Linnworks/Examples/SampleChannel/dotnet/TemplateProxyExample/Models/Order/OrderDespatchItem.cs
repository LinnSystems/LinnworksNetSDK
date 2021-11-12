using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Order
{
    public class OrderDespatchItem
    {
        /// <summary>
        /// Channel SKU from the order item.
        /// </summary>
        public string SKU { get; set; }

        /// <summary>
        /// Unique line number from the order item.
        /// </summary>
        public string OrderLineNumber { get; set; }

        /// <summary>
        /// Quantity despatched, due to splits this might be less than the original order and additional
        /// quantity may be provided later.
        /// </summary>
        public int DespatchedQuantity { get; set; }
    }
}