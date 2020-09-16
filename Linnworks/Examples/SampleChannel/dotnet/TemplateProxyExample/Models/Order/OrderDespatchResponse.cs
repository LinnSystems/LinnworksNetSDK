using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Order
{
    public class OrderDespatchResponse : BaseResponse
    {
        public List<OrderDespatchError> Orders { get; set; }
    }
}