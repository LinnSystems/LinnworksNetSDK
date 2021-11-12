using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Order
{
    public class OrderDespatchError : BaseResponse
    {
        /// <summary>
        /// Reference number of the order.
        /// </summary>
        public string ReferenceNumber { get; set; }
    }
}