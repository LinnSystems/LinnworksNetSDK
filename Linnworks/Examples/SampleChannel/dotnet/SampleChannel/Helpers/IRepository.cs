using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleChannel.Helpers
{
    public interface IRepository
    {
        bool Exists(string authorizationToken);
        string Load(string authorizationToken);
        void Save(string authorizationToken, string contents);

        void Delete(string authorizationToken);

    }
}
