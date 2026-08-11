using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class PrintZoneController : BaseController, IPrintZoneController
    {
        public PrintZoneController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Gets a list of all print zones 
        /// </summary>
        /// <returns>List of Print Zone Id, Code and Name</returns>
        public GetAllPrintZonesResponse GetAllPrintZones()
		{
			var response = GetResponse("PrintZone/GetAllPrintZones", "");
            return JsonFormatter.ConvertFromJson<GetAllPrintZonesResponse>(response);
		} 
    }
}