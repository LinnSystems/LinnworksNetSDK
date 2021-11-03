using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.Extensions.Configuration;

namespace TemplateProxyExample.Models.User
{
    public class UserConfig : BaseRequest
    {
        private string userStoreLocation;

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

        public static UserConfig Load(string userStoreLocation, string authorizationToken)
        {
            if (string.IsNullOrWhiteSpace(authorizationToken))
                throw new ArgumentNullException("authorizationToken");

            string path = string.Concat(userStoreLocation, "\\", authorizationToken, ".json");

            if (System.IO.File.Exists(path))
            {
                string json = System.IO.File.ReadAllText(path);
                UserConfig output = Newtonsoft.Json.JsonConvert.DeserializeObject<UserConfig>(json);
                return output;
            }
            else
            {
                return null;
            }

        }

        public static void Delete(string userStoreLocation, string authorizationToken)
        {
            string path = string.Concat(authorizationToken, "\\", authorizationToken, ".json");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public static UserConfig CreateNew(string email, Guid linnworksUniqueIdentifier, string accountName, string userStoreLocation)
        {
            UserConfig result = new UserConfig();
            result.userStoreLocation = userStoreLocation;
            result.AuthorizationToken = Guid.NewGuid().ToString("N");
            result.Email = email;
            result.LinnworksUniqueIdentifier = linnworksUniqueIdentifier;
            result.AccountName = accountName;
            result.Save();
            return result;
        }

        public void Save()
        {
            string path = string.Concat(this.userStoreLocation, "\\", this.AuthorizationToken, ".json");
            var output = Newtonsoft.Json.JsonConvert.SerializeObject(this);

            File.WriteAllText(path, output);
        }
    }
}