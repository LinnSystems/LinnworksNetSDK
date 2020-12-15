using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class PickingController : BaseController, IPickingController
    {
        public PickingController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Check a list of Linnworks order ids to see if they can be added to a pickwave 
        /// </summary>
        /// <param name="request"></param>
        public CheckAllocatableToPickwaveResponse CheckAllocatableToPickwave(CheckAllocatableToPickwaveRequest request)
		{
			var response = GetResponse("Picking/CheckAllocatableToPickwave", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<CheckAllocatableToPickwaveResponse>(response);
		}

		/// <summary>
        /// Delete one or more orders from a pickwave 
        /// </summary>
        /// <param name="request"></param>
        public DeleteOrdersFromPickingWavesResponse DeleteOrdersFromPickingWaves(DeleteOrdersFromPickingWavesRequest request)
		{
			var response = GetResponse("Picking/DeleteOrdersFromPickingWaves", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<DeleteOrdersFromPickingWavesResponse>(response);
		}

		/// <summary>
        /// Generate a new pickwave 
        /// </summary>
        /// <param name="request"></param>
        public GeneratePickingWaveResponse GeneratePickingWave(PickingWaveGenerate request)
		{
			var response = GetResponse("Picking/GeneratePickingWave", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GeneratePickingWaveResponse>(response);
		}

		/// <summary>
        /// Get a list of all pickwaves 
        /// </summary>
        /// <param name="request"></param>
        public GetPickingWaveHeadersResponse GetAllPickingWaveHeaders(GetPickingWavesRequest request)
		{
			var response = GetResponse("Picking/GetAllPickingWaveHeaders", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetPickingWaveHeadersResponse>(response);
		}

		/// <summary>
        /// Get a list of all pickwaves 
        /// </summary>
        /// <param name="request"></param>
        public GetPickingWavesResponse GetAllPickingWaves(GetPickingWavesRequest request)
		{
			var response = GetResponse("Picking/GetAllPickingWaves", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetPickingWavesResponse>(response);
		}

		/// <summary>
        /// Returns a list of places that the requested item can be found, other than the location already suggested. 
        /// </summary>
        /// <param name="request"></param>
        public GetItemBinracksResponse GetItemBinracks(GetItemBinracksRequest request)
		{
			var response = GetResponse("Picking/GetItemBinracks", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetItemBinracksResponse>(response);
		}

		/// <summary>
        /// Get a list of list of pickwaves for the current user 
        /// </summary>
        /// <param name="request"></param>
        public GetPickingWaveHeadersResponse GetMyPickingWaveHeaders(GetPickingWavesRequest request)
		{
			var response = GetResponse("Picking/GetMyPickingWaveHeaders", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetPickingWaveHeadersResponse>(response);
		}

		/// <summary>
        /// Get a list of list of pickwaves for the current user 
        /// </summary>
        /// <param name="request"></param>
        public GetPickingWavesResponse GetMyPickingWaves(GetPickingWavesRequest request)
		{
			var response = GetResponse("Picking/GetMyPickingWaves", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetPickingWavesResponse>(response);
		}

		/// <summary>
        /// Get a specific pickwave by id 
        /// </summary>
        /// <param name="request"></param>
        public GetPickingWavesResponse GetPickingWave(GetPickingWaveRequest request)
		{
			var response = GetResponse("Picking/GetPickingWave", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetPickingWavesResponse>(response);
		}

		/// <summary>
        /// Returns a list of pickwaves as well as dummy entries for users who have permissions to complete pickwaves, but don't currently have any assigned. These entries will have a PickwaveId of 0. 
        /// </summary>
        /// <param name="request"></param>
        public GetPickwaveUsersWithSummaryResponse GetPickwaveUsersWithSummary(GetPickingWavesRequest request)
		{
			var response = GetResponse("Picking/GetPickwaveUsersWithSummary", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetPickwaveUsersWithSummaryResponse>(response);
		}

		/// <summary>
        /// Updates the batch/binrack for allocated pickwave item. Only applicable to pickwave items with batch information		 
        /// </summary>
        /// <param name="request"></param>
        public GetPickingWavesResponse UpdatePickedItemDelta(UpdatePickedItemDeltaRequest request)
		{
			var response = GetResponse("Picking/UpdatePickedItemDelta", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetPickingWavesResponse>(response);
		}

		/// <summary>
        /// Update a pickwave header 
        /// </summary>
        /// <param name="request"></param>
        public GetPickingWavesResponse UpdatePickingWaveHeader(PickingWaveUpdateRequest request)
		{
			var response = GetResponse("Picking/UpdatePickingWaveHeader", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetPickingWavesResponse>(response);
		}

		/// <summary>
        /// Update on or more pickwave items 
        /// </summary>
        /// <param name="request"></param>
        public GetPickingWavesResponse UpdatePickingWaveItem(PickingWaveItemUpdateRequest request)
		{
			var response = GetResponse("Picking/UpdatePickingWaveItem", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetPickingWavesResponse>(response);
		}

		/// <summary>
        /// Updates the batch/binrack for allocated pickwave item. Only applicable to pickwave items with batch information		 
        /// </summary>
        /// <param name="request"></param>
        public GetPickingWavesResponse UpdatePickingWaveItemWithNewBinrack(UpdatePickingWaveItemWithNewBinrackRequest request)
		{
			var response = GetResponse("Picking/UpdatePickingWaveItemWithNewBinrack", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetPickingWavesResponse>(response);
		} 
    }
}