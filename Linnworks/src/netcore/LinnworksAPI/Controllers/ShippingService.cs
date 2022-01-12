using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class ShippingServiceController : BaseController, IShippingServiceController
    {
        public ShippingServiceController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Cancels the shipping label for an order 
        /// </summary>
        /// <param name="request"></param>
        public CancelOrderShippingLabelResponse CancelOrderShippingLabel(CancelOrderShippingLabelRequest request)
		{
			var response = GetResponse("ShippingService/CancelOrderShippingLabel", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<CancelOrderShippingLabelResponse>(response);
		}

		public void PostShipmentUpload(PostShipmentUploadRequest request)
		{
			GetResponse("ShippingService/PostShipmentUpload", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		} 
    }
}