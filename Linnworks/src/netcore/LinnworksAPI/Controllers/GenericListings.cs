using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class GenericListingsController : BaseController, IGenericListingsController
    {
        public GenericListingsController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Use this call to create a configurator. The configurator setup will be dependant on the channel that you want to create it for.
        /// 
        /// More information on configurators can be found in the [Linnworks general documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <param name="request"></param>
        public CreateConfiguratorResponse CreateConfigurator(CreateConfiguratorRequest request)
		{
			var response = GetResponse("GenericListings/CreateConfigurator", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<CreateConfiguratorResponse>(response);
		}

		/// <summary>
        /// Use this call to create a generic template based on the inventory item details and the configurator details. This template will contain the full details of the item that will be listed on the channel. 
        /// </summary>
        /// <param name="request"></param>
        public CreateTemplatesResponse CreateTemplates(CreateTemplatesRequest request)
		{
			var response = GetResponse("GenericListings/CreateTemplates", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<CreateTemplatesResponse>(response);
		}

		/// <summary>
        /// Use this call to delete a configurator.
        /// 
        /// More information on configurators can be found in the [Linnworks general documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <param name="request"></param>
        public DeleteConfiguratorsResponse DeleteConfigurators(DeleteConfiguratorsRequest request)
		{
			var response = GetResponse("GenericListings/DeleteConfigurators", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<DeleteConfiguratorsResponse>(response);
		}

		/// <summary>
        /// Use this call to get the existing Generic Listing Tool configurators data.
        /// 
        /// More information on configurators can be found in the [Linnworks general documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <param name="request"></param>
        public GetConfiguratorDataResponse GetConfiguratorData(GetConfiguratorDataRequest request)
		{
			var response = GetResponse("GenericListings/GetConfiguratorData", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetConfiguratorDataResponse>(response);
		}

		/// <summary>
        /// Use this call to get the existing Generic Listing Tool configurators description.
        /// 
        /// More information on configurators can be found in the [Linnworks general documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <param name="request"></param>
        public GetConfiguratorDescriptionResponse GetConfiguratorDescription(GetConfiguratorDataRequest request)
		{
			var response = GetResponse("GenericListings/GetConfiguratorDescription", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetConfiguratorDescriptionResponse>(response);
		}

		/// <summary>
        /// Use this call to get the existing Generic Listing Tool configurators.
        /// 
        /// More information on configurators can be found in the [Linnworks general documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <param name="request"></param>
        public GetConfiguratorsInfoResponse GetConfiguratorsInfoPaged(GetConfiguratorsInfoPagedRequest request)
		{
			var response = GetResponse("GenericListings/GetConfiguratorsInfoPaged", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetConfiguratorsInfoResponse>(response);
		}

		/// <summary>
        /// Use this call to get template details for Generic Listings using Stock Item IDs. 
        /// </summary>
        /// <param name="request"></param>
        public OpenTemplatesByInventoryResponse OpenTemplatesByInventory(OpenTemplatesByInventoryRequest request)
		{
			var response = GetResponse("GenericListings/OpenTemplatesByInventory", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<OpenTemplatesByInventoryResponse>(response);
		}

		/// <summary>
        /// Use this call to push a template that you have created to a channel. This endpoint can also be used to update, relist, delete a template from a channel. 
        /// </summary>
        /// <param name="request"></param>
        public ProcessTemplatesResponse ProcessTemplates(ProcessTemplatesRequest request)
		{
			var response = GetResponse("GenericListings/ProcessTemplates", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<ProcessTemplatesResponse>(response);
		}

		/// <summary>
        /// Use this call to update a configurators data (attributes of the configurator).
        /// 
        /// More information on configurators can be found in the [Linnworks general documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <param name="request"></param>
        public SaveConfiguratorDataResponse SaveConfiguratorData(SaveConfiguratorDataRequest request)
		{
			var response = GetResponse("GenericListings/SaveConfiguratorData", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<SaveConfiguratorDataResponse>(response);
		}

		/// <summary>
        /// Use this call to update a configurators description.
        /// 
        /// More information on configurators can be found in the [Linnworks general documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <param name="request"></param>
        public SaveConfiguratorDescriptionResponse SaveConfiguratorDescription(SaveConfiguratorDescriptionRequest request)
		{
			var response = GetResponse("GenericListings/SaveConfiguratorDescription", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<SaveConfiguratorDescriptionResponse>(response);
		}

		/// <summary>
        /// Use this call to update a configurators fields.
        /// 
        /// More information on configurators can be found in the [Linnworks general documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <param name="request"></param>
        public SaveConfiguratorFieldsResponse SaveConfiguratorFields(SaveConfiguratorFieldsRequest request)
		{
			var response = GetResponse("GenericListings/SaveConfiguratorFields", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<SaveConfiguratorFieldsResponse>(response);
		}

		/// <summary>
        /// Use this call to manipulate the fields on a template. This can be used to modify a generic template created using the CreateTemplate endpoint. 
        /// </summary>
        /// <param name="request"></param>
        public SaveTemplateFieldsResponse SaveTemplateFields(SaveTemplateFieldsRequest request)
		{
			var response = GetResponse("GenericListings/SaveTemplateFields", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<SaveTemplateFieldsResponse>(response);
		} 
    }
}