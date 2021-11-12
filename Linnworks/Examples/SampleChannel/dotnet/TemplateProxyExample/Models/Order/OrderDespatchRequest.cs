﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Order
{
    public class OrderDespatchRequest : BaseRequest
    {
        public OrderDespatchRequest()
        {
            this.Orders = new List<OrderDespatch>();
        }

        /// <summary>
        /// List of despatch orders <see cref="OrderDespatch"/>.
        /// </summary>
        public List<OrderDespatch> Orders { get; set; }
    }
}