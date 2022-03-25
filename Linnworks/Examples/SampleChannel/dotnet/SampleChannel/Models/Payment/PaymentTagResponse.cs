namespace SampleChannel.Models.Payment
{
    public class PaymentTagResponse : BaseResponse
    {
        /// <summary>
        /// List of payment tags.
        /// </summary>
        public PaymentTag[] PaymentTags { get; set; }
    }
}