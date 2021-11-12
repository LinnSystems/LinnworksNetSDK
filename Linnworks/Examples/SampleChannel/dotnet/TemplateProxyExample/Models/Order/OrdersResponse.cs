namespace TemplateProxyExample.Models.Order
{
    public class OrdersResponse : BaseResponse
    {
        /// <summary>
        /// Indicates if there are more pages after the current page.
        /// </summary>
        public bool HasMorePages { get; set; }

        /// <summary>
        /// The list of orders.
        /// </summary>
        public Order[] Orders { get; set; }
    }
}