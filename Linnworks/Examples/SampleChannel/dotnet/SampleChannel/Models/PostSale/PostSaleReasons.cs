using System.Collections.Generic;

namespace SampleChannel.Models.PostSale
{
    public class PostSaleReasons
    {
        /// <summary>
        /// Value used when submitting to the channel
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// The reason in a nice form that gets desplayed to the user
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// The action this reason relates to
        /// </summary>
        public List<ChannelReasonType> Types { get; set; }

        /// <summary>
        /// Any subreasons for the reason
        /// </summary>
        public List<SubReason> SubReasons { get; set; }
    }

    public class SubReason
    {
        public SubReason() { }

        public SubReason(string displayName, string tag)
        {
            Tag = tag;
            DisplayName = displayName;
        }

        /// <summary>
        /// Value used when submitting to the channel
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// The reason in a nice form that gets desplayed to the user
        /// </summary>
        public string DisplayName { get; set; }
    }

    public enum ChannelReasonType
    {
        Cancellation,
        ItemRefund,
        ShippingRefund,
        ServiceRefund,
        AdditionalRefund
    }
}
