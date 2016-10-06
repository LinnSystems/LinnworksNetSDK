namespace TemplateProxyExample.Models.Order
{
    public class OrdersResponse : BaseResponse
    {
        public bool HasMorePages { get; set; }

        public Order[] Orders { get; set; }
    }
}