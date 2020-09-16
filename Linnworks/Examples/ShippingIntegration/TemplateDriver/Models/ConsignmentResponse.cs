using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateDriver.Models
{
    public class CancelLabelResponse : BaseClasses.BaseResponse
    {
        public CancelLabelResponse(string error) : base(error) { }
        public CancelLabelResponse() : base() { }
    }


    public class GenerateLabelResponse : BaseClasses.BaseResponse
    {
        public GenerateLabelResponse(string error) : base(error) { }
        public GenerateLabelResponse() : base() { }

        public string LeadTrackingNumber = "";
        public decimal Cost = 0;
        public string Currency = "GBP";

        public List<PackageResponse> Package = new List<PackageResponse>();
    }

    public class PackageResponse {
        public int SequenceNumber;
        public string TrackingNumber;
        public string PNGLabelDataBase64;
        public string[] PDFBytesDocumentationBase64;
        public decimal LabelWidth;
        public decimal LabelHeight;
    }
}