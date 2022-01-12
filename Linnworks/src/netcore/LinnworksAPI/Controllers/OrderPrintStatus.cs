using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class OrderPrintStatusController : BaseController, IOrderPrintStatusController
    {
        public OrderPrintStatusController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Set Order Print Status flag in database so that on refresh, Open orders "printed" flag is highlighted. 
        /// </summary>
        /// <param name="result">Processed Print job information</param>
        public void SetOrderPrintStatus(PrintJobProcessedDto result)
		{
			GetResponse("OrderPrintStatus/SetOrderPrintStatus", "result=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(result)) + "");
		} 
    }
}