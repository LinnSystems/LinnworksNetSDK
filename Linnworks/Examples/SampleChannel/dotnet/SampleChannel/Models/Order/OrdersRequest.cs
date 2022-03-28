namespace SampleChannel.Models.Order
{
    public class OrdersRequest : BaseRequest
    {
        public OrdersRequest()
        {
            this.PageNumber = 1;
        }

        /// <summary>
        /// Page number of the request. Starts from 1.
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// Utc date from Linnworks since the last time we had a successful orders request.
        /// This may change from Linnworks side if the user want’s to back date the sync.
        /// It is suggested that if the channels API has the availability of filtering by the
        /// last time the order was updated to use this. Format: ​"yyyy-MM-dd HH:mm:ssZ".
        /// </summary>
        public System.DateTime UTCTimeFrom { get; set; }
    }

}