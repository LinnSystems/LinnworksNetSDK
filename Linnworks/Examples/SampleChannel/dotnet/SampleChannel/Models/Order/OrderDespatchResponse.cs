using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleChannel.Models.Order
{
    public class OrderDespatchResponse : BaseResponse
    {
        /// <summary>
        /// Orders <see cref="OrderDespatchError"/>
        /// </summary>
        public List<OrderDespatchError> Orders { get; set; }
    }
}