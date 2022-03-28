namespace SampleChannel.Models.Order
{
    public class OrderDespatchError : BaseResponse
    {
        /// <summary>
        /// Reference number of the order.
        /// </summary>
        public string ReferenceNumber { get; set; }
    }
}