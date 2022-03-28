using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SampleChannel.Helpers;

namespace SampleChannel.Config
{
    public class AppSettings
    {
        public string UserStoreLocation { get; set; }

        public virtual IRepository FileRepository
        {
            get
            {
                if(!Directory.Exists(this.UserStoreLocation))
                {
                    Directory.CreateDirectory(this.UserStoreLocation);
                }

                return new FileRepository(this.UserStoreLocation);
            }
        }
    }
}
