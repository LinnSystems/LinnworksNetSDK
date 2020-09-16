using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.User
{
    public class UserConfig : BaseRequest
    {
        public UserConfig()
        {
            this.IsOauth = true;
            this.StepName = "AddCredentials";
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

        public static UserConfig Load(string authorizationToken)
        {
            if (string.IsNullOrWhiteSpace(authorizationToken))
                throw new ArgumentNullException("authorizationToken");

            string path = string.Concat(Helpers.ServiceHelper.UserStoreLocation, "\\", authorizationToken, ".json");

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                UserConfig output = Newtonsoft.Json.JsonConvert.DeserializeObject<UserConfig>(json);
                return output;
            }
            else
            {
                return null;
            }

        }

        public static void Delete(string authorizationToken)
        {
            string path = string.Concat(Helpers.ServiceHelper.UserStoreLocation, "\\", authorizationToken, ".json");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public static UserConfig CreateNew(string email, Guid linnworksUniqueIdentifier, string accountName)
        {
            UserConfig result = new UserConfig();
            result.AuthorizationToken = Guid.NewGuid().ToString("N");
            result.Email = email;
            result.LinnworksUniqueIdentifier = linnworksUniqueIdentifier;
            result.AccountName = accountName;
            result.Save();
            return result;
        }

        public void Save()
        {
            string path = string.Concat(Helpers.ServiceHelper.UserStoreLocation, "\\", this.AuthorizationToken, ".json");
            var output = Newtonsoft.Json.JsonConvert.SerializeObject(this);

            File.WriteAllText(path, output);
        }
    }
}