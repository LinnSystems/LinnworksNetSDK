using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Order
{
    public class OrderDespatchItem
    {
        public string SKU { get; set; }
        public string OrderLineNumber { get; set; }
        public int DespatchedQuantity { get; set; }
    }
}