using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateDriver.Models
{
    public class CreateManifestRequest : BaseClasses.BaseRequest
    {
        public List<string> OrderId = new List<string>();
    }

    public class PrintManifestRequest : BaseClasses.BaseRequest {
        public string ManifestReference;
    }




}