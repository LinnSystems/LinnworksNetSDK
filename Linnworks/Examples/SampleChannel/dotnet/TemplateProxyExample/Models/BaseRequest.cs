using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models
{
    public class BaseRequest
    {
        /// <summary>
        /// Authorization Token from the customers integration.
        /// </summary>
        public string AuthorizationToken { get; set; }
    }
}