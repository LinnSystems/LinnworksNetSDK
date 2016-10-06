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
        public bool TaxCostInclusive { get; set; }
        public bool UseChannelTax { get; set; }
        public bool IsService { get; set; }
        #endregion Settings

        public string OrderLineNumber { get; set; }
        public string SKU { get; set; }
        public decimal PricePerUnit { get; set; }
        public int Qty { get; set; }
        public decimal TaxRate { get; set; }
        public decimal LinePercentDiscount { get; set; }
        public string ItemTitle { get; set; }
        public List<OrderItemOption> Options { get; set; }
    }
}