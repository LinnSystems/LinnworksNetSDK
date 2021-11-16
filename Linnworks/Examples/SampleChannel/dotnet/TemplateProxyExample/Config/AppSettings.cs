using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TemplateProxyExample.Helpers;

namespace TemplateProxyExample.Config
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
