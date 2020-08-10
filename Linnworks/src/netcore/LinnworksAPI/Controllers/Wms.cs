using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class WmsController : BaseController, IWmsController
    {
        public WmsController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        public AddWarehouseZoneResponse AddWarehouseZone(AddWarehouseZoneRequest request)
		{
			var response = GetResponse("Wms/AddWarehouseZone", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AddWarehouseZoneResponse>(response);
		}

		public AddWarehouseZoneTypeResponse AddWarehouseZoneType(AddWarehouseZoneTypeRequest request)
		{
			var response = GetResponse("Wms/AddWarehouseZoneType", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AddWarehouseZoneTypeResponse>(response);
		}

		public DeleteWarehouseZoneResponse DeleteWarehouseZone(DeleteWarehouseZoneRequest request)
		{
			var response = GetResponse("Wms/DeleteWarehouseZone", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<DeleteWarehouseZoneResponse>(response);
		}

		public DeleteWarehouseZoneTypeResponse DeleteWarehouseZoneType(DeleteWarehouseZoneTypeRequest request)
		{
			var response = GetResponse("Wms/DeleteWarehouseZoneType", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<DeleteWarehouseZoneTypeResponse>(response);
		}

		public GetBinrackZonesByBinrackIdOrNameResponse GetBinrackZonesByBinrackIdOrName(GetBinrackZonesByBinrackIdOrNameRequest request)
		{
			var response = GetResponse("Wms/GetBinrackZonesByBinrackIdOrName", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetBinrackZonesByBinrackIdOrNameResponse>(response);
		}

		public GetBinrackZonesByZoneIdOrNameResponse GetBinrackZonesByZoneIdOrName(GetBinrackZonesByZoneIdOrNameRequest request)
		{
			var response = GetResponse("Wms/GetBinrackZonesByZoneIdOrName", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetBinrackZonesByZoneIdOrNameResponse>(response);
		}

		public GetWarehouseZonesByLocationResponse GetWarehouseZonesByLocation(GetWarehouseZonesByLocationRequest request)
		{
			var response = GetResponse("Wms/GetWarehouseZonesByLocation", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetWarehouseZonesByLocationResponse>(response);
		}

		public GetWarehouseZoneTypesResponse GetWarehouseZoneTypes(GetWarehouseZoneTypesRequest request)
		{
			var response = GetResponse("Wms/GetWarehouseZoneTypes", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetWarehouseZoneTypesResponse>(response);
		}

		public UpdateWarehouseBinrackBinrackToZoneResponse UpdateWarehouseBinrackBinrackToZone(UpdateWarehouseBinrackBinrackToZoneRequest request)
		{
			var response = GetResponse("Wms/UpdateWarehouseBinrackBinrackToZone", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<UpdateWarehouseBinrackBinrackToZoneResponse>(response);
		}

		public UpdateWarehouseZoneResponse UpdateWarehouseZone(UpdateWarehouseZoneRequest request)
		{
			var response = GetResponse("Wms/UpdateWarehouseZone", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<UpdateWarehouseZoneResponse>(response);
		}

		public UpdateWarehouseZoneTypeResponse UpdateWarehouseZoneType(UpdateWarehouseZoneTypeRequest request)
		{
			var response = GetResponse("Wms/UpdateWarehouseZoneType", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<UpdateWarehouseZoneTypeResponse>(response);
		} 
    }
}