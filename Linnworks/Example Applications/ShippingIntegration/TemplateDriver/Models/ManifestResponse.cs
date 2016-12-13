using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateDriver.Models
{
    public class CreateManifestResponse : BaseClasses.BaseResponse
    {
        public CreateManifestResponse(string error) : base(error) { }
        public CreateManifestResponse() : base() { }

        public string ManifestReference;
    }

    public class PrintManifestResponse : BaseClasses.BaseResponse {
        public string PDFbase64;

        public PrintManifestResponse(string error) : base(error) { }
        public PrintManifestResponse() : base() { }
    }
}