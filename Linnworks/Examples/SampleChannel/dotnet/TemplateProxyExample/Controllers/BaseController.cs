using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TemplateProxyExample.Config;
using TemplateProxyExample.Helpers;

namespace TemplateProxyExample.Controllers
{
    public class BaseController : ControllerBase
    {
        private readonly IOptions<AppSettings> Config;

        public BaseController (IOptions<AppSettings> config)
        {
            Config = config;
        }

        /// <summary>
        /// Gets the repository that handles the actual reading and writing to and from the filesystem.
        /// </summary>
        protected IRepository FileRepository
        {
            get
            {
                return Config.Value.FileRepository;
            }
        }
    }
}
