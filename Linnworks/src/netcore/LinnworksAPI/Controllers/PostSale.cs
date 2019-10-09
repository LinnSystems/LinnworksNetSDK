using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class PostSaleController : BaseController, IPostSaleController
    {
        public PostSaleController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// This method is used to further validate and create a cancellation in Linnworks, as well as submit it to the channel where this is requested 
        /// </summary>
        /// <param name="request">The requested cancellation settings, including whether or not to submit the cancellation to the channel</param>
        /// <returns>A validation and submission result (where appropriate) for the requested cancellation</returns>
        public ValidatedCancellation CreateCancellation(CancellationRequest request)
		{
			var response = GetResponse("PostSale/CreateCancellation", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<ValidatedCancellation>(response);
		} 
    }
}