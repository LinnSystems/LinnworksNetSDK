using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TemplateDriver.Controllers
{
    public class ManifestController : ApiController
    {
        [HttpPost()]
        [ActionName("CreateManifest")]
        public Models.CreateManifestResponse CreateManifest(Models.CreateManifestRequest request) {
            Classes.AuthorizationConfig auth = Classes.AuthorizationConfig.Load(request.AuthorizationToken);
            if (auth == null)
            {
                return new Models.CreateManifestResponse("Authorization failed for token " + request.AuthorizationToken);
            }

            //here we can implement manifest submission, upload etc if needed
            //the request will contain all orderIds the customer is manifesting 
            // in this specific example we simply output a dummy manifest reference
            return new Models.CreateManifestResponse() {
                ManifestReference = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper()
            };
        }

        [HttpPost()]
        [ActionName("PrintManifest")]
        public Models.PrintManifestResponse PrintManifest(Models.PrintManifestRequest request) {
            Classes.AuthorizationConfig auth = Classes.AuthorizationConfig.Load(request.AuthorizationToken);
            if (auth == null)
            {
                return new Models.PrintManifestResponse("Authorization failed for token " + request.AuthorizationToken);
            }
            // if there is a specific End-Of-Day/Manifest documentation you can generate the PDF here
            // if you integration doesn't support manifest document or it is not needed simply throw an error via the response of course and state: This integration doesn't support End Of Day manifest documentation. 

            return new Models.PrintManifestResponse() {
                PDFbase64 = Convert.ToBase64String(test_resource.MANIFEST)
            };

        }


    }
}
