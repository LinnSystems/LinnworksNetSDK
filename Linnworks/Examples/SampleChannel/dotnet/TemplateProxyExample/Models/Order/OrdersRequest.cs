namespace TemplateProxyExample.Models.Order
{
    public class OrdersRequest : BaseRequest
    {
        public OrdersRequest()
        {
            this.PageNumber = 1;
        }

        public int PageNumber { get; set; }

        public System.DateTime UTCTimeFrom { get; set; }
    }

}