using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TemplateProxyExample.Config;

namespace TemplateProxyExample.Controllers
{
    public class BaseController : ControllerBase
    {
        private readonly IOptions<AppSettings> Config;

        public BaseController (IOptions<AppSettings> config)
        {
            Config = config;
        }

        protected string UserStoreLocation
        {
            get
            {
                var path = Config.Value.UserStoreLocation;

                if (Directory.Exists(path))
                    Directory.CreateDirectory(path);

                return path;
            }
        }
    }
}
