using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LinnworksAPI
{
    public class OpenOrdersController : BaseController, IOpenOrdersController
    {
        public OpenOrdersController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Add an identifier to an order 
        /// </summary>
        public AssignResult AssignOrderIdentifier(ChangeOrderIdentifierRequest request)
		{
			var response = GetResponse("OpenOrders/AssignOrderIdentifier", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AssignResult>(response);
		}

		/// <summary>
        /// Remove identifier from an order 
        /// </summary>
        public AssignResult UnassignOrderIdentifier(ChangeOrderIdentifierRequest request)
		{
			var response = GetResponse("OpenOrders/UnassignOrderIdentifier", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AssignResult>(response);
		}
    }
}