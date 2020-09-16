using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateDriver.Classes
{
    public class AuthorizationConfig
    {
        public string Email;
        public string LinnworksUniqueIdentifier;
        public DateTime IntegratedDateTime = DateTime.UtcNow;
        public Guid AuthorizationToken;
        public string AccountName;
        public Boolean IsConfigActive = false;
        public string ConfigStatus="";

        public string AddressLine1 = "";
        public string AddressLine2 = "";
        public string AddressLine3 = "";
        public string City = "";
        public string ContactName = "";
        public string ContactPhoneNo = "";
        public string CountryCode = "GB";
        public string County = "";
        public string Postcode = "";


        public static AuthorizationConfig Load(string AuthorizationToken) {
            if (System.IO.File.Exists(AppSettings.ConfigStoragePath + "\\" + AuthorizationToken + ".json"))
            {
                string json = System.IO.File.ReadAllText(AppSettings.ConfigStoragePath + "\\" + AuthorizationToken + ".json");
                AuthorizationConfig output = Newtonsoft.Json.JsonConvert.DeserializeObject<AuthorizationConfig>(json);
                return output;
            }
            else {
                return null;
            }
        }

        public static void Delete(string AuthorizationToken)
        {
            if (System.IO.File.Exists(AppSettings.ConfigStoragePath + "\\" + AuthorizationToken + ".json"))
            {
                System.IO.File.Delete(AppSettings.ConfigStoragePath + "\\" + AuthorizationToken + ".json");
            }
        }

        public static AuthorizationConfig CreateNew(string email, string LinnworksUniqueIdentifier, string accountName) {
            AuthorizationConfig output = new AuthorizationConfig();
            output.AuthorizationToken = Guid.NewGuid();
            output.Email = email;
            output.LinnworksUniqueIdentifier = LinnworksUniqueIdentifier;
            output.AccountName = accountName;
            output.Save();
            return output;
        }

        public void Save() {
            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(AppSettings.ConfigStoragePath+"\\"+this.AuthorizationToken.ToString()+".json");
            sw.Write(jsonData);
            sw.Close();
        }

    }
}