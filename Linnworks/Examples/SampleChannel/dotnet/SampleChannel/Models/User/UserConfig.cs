using System;

namespace SampleChannel.Models.User
{
    public class UserConfig : BaseRequest
    {
        public UserConfig() 
        {
            this.IsOauth = true;
            this.StepName = ConfigStagesEnum.AddCredentials.ToString();
        }

        public UserConfig(string authorizationToken)
        {
            this.AuthorizationToken = authorizationToken;
        }

        public string Email { get; set; }

        public Guid LinnworksUniqueIdentifier { get; set; }

        public bool IsComplete { get; set; }
        public string StepName { get; set; }
        public string AccountName { get; set; }
        public bool IsConfigActive { get; set; }
        public string APIKey { get; set; }
        public string APISecretKey { get; set; }
        public bool IsOauth { get; set; }
        public bool PriceIncTax { get; set; }
        public bool DownloadVirtualItems { get; set; }
    }
}