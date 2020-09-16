using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TemplateDriver.Controllers
{
    public class ConsignmentController : ApiController
    {
        [HttpPost()]
        [ActionName("GenerateLabel")]
        public Models.GenerateLabelResponse GenerateLabel(Models.GenerateLabelRequest request)
        {
            try
            {
                // lets authenticate the user and make sure we have their config details
                Classes.AuthorizationConfig auth = Classes.AuthorizationConfig.Load(request.AuthorizationToken);
                if (auth == null)
                {
                    return new Models.GenerateLabelResponse("Authorization failed for token " + request.AuthorizationToken);
                }

                // load all the services we have (either for this user specifically or all services)
                List<Classes.CourierService> services = Services.GetServices;

                //linnworks will send the serviceId as defined in list of services, we will need to find the service by id 
                Classes.CourierService selectedService = services.Find(s => s.ServiceUniqueId == request.ServiceId);
                if (selectedService == null)
                {
                    throw new Exception("Service Id " + request.ServiceId.ToString() + " is not available");
                }

                // get the service code
                string serviceCode = selectedService.ServiceCode;
                //and some other information, whatever we need
                string VendorCode = selectedService.ServiceGroup;
                
                //create response class, we will be adding packages to it
                Models.GenerateLabelResponse response = new Models.GenerateLabelResponse();


                 /* If you need to do any validation of services or consignment data, do it before you generate labels and simply throw an error 
                  * on the whole request
                  */

                foreach (var package in request.Packages)   // we need to generate a label for each package in the consignment
                {
                    // an order may have extended property bound to it, here we can pass any specific parameter we need
                    // in this specific example we will be taking SafePlace extended property of the order and outputting it on the label
                    string safePlace1 = "";
                    if (request.OrderExtendedProperties.Find(s => s.Name == "SafePlace1") != null) {
                        safePlace1 = request.OrderExtendedProperties.Find(s => s.Name == "SafePlace1").Value;
                    }

                    //generate new tracking number
                    string newTrackingNumber = request.CountryCode + " " + Guid.NewGuid().ToString().Substring(0, 8).ToUpper();

                    // each consignment must have lead tracking number. In case of multiple packages this will be the main tracking number which allows us to track the whole shipment by one tracking number. When the courier doesn't support this simply allocate the first package tracking number as a lead tracking number
                    if (response.LeadTrackingNumber == "") { response.LeadTrackingNumber = newTrackingNumber; }

                    // we now need to add packages back into response, one item per package which contains label and any associated documentation
                    response.Package.Add(new Models.PackageResponse() {
                        LabelHeight = 6,                // label height in inches
                        LabelWidth = 4,                 // label width in inches
                        PNGLabelDataBase64 = Convert.ToBase64String(imageToByteArray(LabelGenerator.GenerateLabel(request.ServiceConfigItems, safePlace1, serviceCode, request.OrderReference, newTrackingNumber, CodeHelper.FormatAddress(request)))), // generate the label image, get its bytes and convert bytes to Base64 string
                        SequenceNumber = package.SequenceNumber,    //VERY IMPORTANT TO PRESERVE Sequence number for each package!!!!
                        PDFBytesDocumentationBase64 = new string[] { },         // here we can add any additional documentation, such as customs forms, declarations etc. PDF files converted to Base64 string
                        TrackingNumber = newTrackingNumber          // package tracking number
                    });

                    /* Here you can also save the consignment data and associate package/label information in some sort of database
                     * if you need to have manifestation or label cancelation reference numbers associated with orderReferences or Order Ids in linnworks
                     */                     
                }



                return response;
            }
            catch (Exception ex) {
                return new Models.GenerateLabelResponse("Unhandled error " +ex.Message);
            }
        }

        static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        [HttpPost()]
        [ActionName("CancelLabel")]
        public Models.CancelLabelResponse CancelLabel(Models.CancelLabelRequest request)
        {
            Classes.AuthorizationConfig auth = Classes.AuthorizationConfig.Load(request.AuthorizationToken);
            if (auth == null)
            {
                return new Models.CancelLabelResponse("Authorization failed for token " + request.AuthorizationToken);
            }

            // implement label cancelation routine here 
            // remember that request will 

            return new Models.CancelLabelResponse();

        }
    }
}
    
