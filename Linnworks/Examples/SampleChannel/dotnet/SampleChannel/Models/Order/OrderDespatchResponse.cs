using System.Collections.Generic;

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