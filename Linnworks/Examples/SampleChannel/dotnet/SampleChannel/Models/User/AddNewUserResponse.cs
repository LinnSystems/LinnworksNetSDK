namespace SampleChannel.Models.User
{
    public class AddNewUserResponse : BaseResponse
    {
        /// <summary>
        /// If successful the authorization token string of the customer.
        /// This will be used for all subsequent calls.
        /// </summary>
        public string AuthorizationToken { get; set; }
    }
}