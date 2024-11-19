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

		/// <summary>
        /// Get paged list of consignments for a specific vendor, account id and manifest id. Use /ShippingService/GetFiledManifestsByVendor for input arguments. 
        /// </summary>
        /// <param name="vendor">Vendor name</param>
        /// <param name="accountId">Account id</param>
        /// <param name="pkManifestId">Manifest id</param>
        /// <param name="externalManifestId">External manifest id. If is null, all consignments for this account will be returned</param>
        /// <param name="manifestDate">The date at which the manifest was filed. Leave empty.</param>
        /// <returns>Paged list of consignments</returns>
        public GenericPagedResult<Consignment> GetConsignmentsByManifest(String vendor,String accountId,Int32 pkManifestId,Guid? externalManifestId,DateTime? manifestDate)
		{
			var response = GetResponse("ShippingService/GetConsignmentsByManifest", "vendor=" + System.Net.WebUtility.UrlEncode(vendor) + "&accountId=" + System.Net.WebUtility.UrlEncode(accountId) + "&pkManifestId=" + pkManifestId + "&externalManifestId=" + externalManifestId + "&manifestDate=" + System.Net.WebUtility.UrlEncode(manifestDate.HasValue ? manifestDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : "null") + "", "GET");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<Consignment>>(response);
		}

		/// <summary>
        /// Gets a paged list of filed manifest by vendor between two dates. Use /ShippingService/GetIntegrations to get all vendors and friendly names 
        /// </summary>
        /// <param name="vendor">Vendor name</param>
        /// <param name="vendorFriendlyName">Vendor friendly name</param>
        /// <param name="from">From date</param>
        /// <param name="to">To date</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="entriesPerPage">Entries per page</param>
        /// <returns>A list of filed manifests by a specific vendor</returns>
        public GenericPagedResult<FiledManifest> GetFiledManifestsByVendor(String vendor,String vendorFriendlyName,DateTime from,DateTime to,Int32 pageNumber,Int32 entriesPerPage)
		{
			var response = GetResponse("ShippingService/GetFiledManifestsByVendor", "vendor=" + System.Net.WebUtility.UrlEncode(vendor) + "&vendorFriendlyName=" + System.Net.WebUtility.UrlEncode(vendorFriendlyName) + "&from=" + System.Net.WebUtility.UrlEncode(from.ToString("yyyy-MM-dd HH:mm:ss")) + "&to=" + System.Net.WebUtility.UrlEncode(to.ToString("yyyy-MM-dd HH:mm:ss")) + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<FiledManifest>>(response);
		}

		/// <summary>
        /// Gets all configured vendor integrations 
        /// </summary>
        /// <returns>List of vendor integrations</returns>
        public List<System_ShippingAPI_Config> GetIntegrations()
		{
			var response = GetResponse("ShippingService/GetIntegrations", "");
            return JsonFormatter.ConvertFromJson<List<System_ShippingAPI_Config>>(response);
		}

		public void PostShipmentUpload(PostShipmentUploadRequest request)
		{
			GetResponse("ShippingService/PostShipmentUpload", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		} 
    }
}