using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Order
{
    public class OrderItemOption
    {
        /// <summary>
        /// Unique per order option Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Option Value.
        /// </summary>
        public string Value { get; set; }
    }
}