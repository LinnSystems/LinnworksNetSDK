using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SampleChannel.Helpers
{
    public class FileRepository : IRepository
    {
        private string userStoreLocation;

        public FileRepository(string userStoreLocation)
        {
            this.userStoreLocation = userStoreLocation;
        }

        public void Delete(string authorizationToken)
        {
            File.Delete(this.Path(authorizationToken));
        }

        public bool Exists(string authorizationToken)
        {
            return File.Exists(this.Path(authorizationToken));
        }

        public string Load(string authorizationToken)
        {
            return File.ReadAllText(this.Path(authorizationToken));
        }

        public void Save(string authorizationToken, string contents)
        {
            File.WriteAllText(this.Path(authorizationToken), contents);
        }

        private string Path(string authorizationToken)
        {
            return string.Concat(this.userStoreLocation, "//", authorizationToken, ".json");
        }
    }
}
