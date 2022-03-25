using System.IO;

namespace SampleChannel.Helpers
{
    public class FileRepository : IRepository
    {
        private readonly string _userStoreLocation;

        public FileRepository(string userStoreLocation)
        {
            this._userStoreLocation = userStoreLocation;
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
            return string.Concat(this._userStoreLocation, "//", authorizationToken, ".json");
        }
    }
}
