using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LinnworksAPI
{
    public class ListingsController : BaseController, IListingsController
    {
        public ListingsController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Use this call to create BigCommerce configurators.
        /// 
        ///  A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <param name="configs">Configs to create</param>
        public void CreateBigcommerceConfigurators(List<BigCommerceConfigurator> configs)
		{
			GetResponse("Listings/CreateBigcommerceConfigurators", "configs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(configs)) + "");
		}

		/// <summary>
        /// Use this call to return a template based on the configurator setting you have requested. This allows you to see the template which can then be  retuned to the ProcessBigCommerceListing endpoint which will build the listing. 
        /// </summary>
        /// <param name="parameters">Object of TemplatesParameters</param>
        /// <returns>List of Bigcommerce Listings</returns>
        public PagedResult<BigCommerceListing> CreateBigcommerceTemplates(ProcessTemplatesParameters parameters)
		{
			var response = GetResponse("Listings/CreateBigcommerceTemplates", "parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "");
            return JsonFormatter.ConvertFromJson<PagedResult<BigCommerceListing>>(response);
		}

		/// <summary>
        /// Use this call to create eBay configurators.
        /// 
        ///  A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme.The same configurator can be used to list multiple items that share common details.To find out more about configurators you can visit our [documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <param name="configs">Configs to create</param>
        public void CreateeBayConfigurators(List<EbayConfig> configs)
		{
			GetResponse("Listings/CreateeBayConfigurators", "configs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(configs)) + "");
		}

		/// <summary>
        /// Use this call to return a template based on the configurator setting you have requested. This allows you to see the template which can then be  retuned to the ProcessEbayListing endpoint which will build the listing. 
        /// </summary>
        /// <param name="parameters">Object of TemplatesParameters</param>
        /// <returns>List of eBay Listings</returns>
        public PagedResult<EbayListing> CreateEbayTemplates(ProcessTemplatesParameters parameters)
		{
			var response = GetResponse("Listings/CreateEbayTemplates", "parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "");
            return JsonFormatter.ConvertFromJson<PagedResult<EbayListing>>(response);
		}

		/// <summary>
        /// Use this call to delete BigCommerce configurators.
        /// 
        ///  A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <param name="configs">Configs to delete</param>
        public void DeleteBigcommerceConfigurators(List<Guid> configs)
		{
			GetResponse("Listings/DeleteBigcommerceConfigurators", "configs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(configs)) + "");
		}

		/// <summary>
        /// Use this call to delete a Big Commerce template. 
        /// </summary>
        /// <param name="templateIds"></param>
        public void DeleteBigcommerceTemplates(IEnumerable<Guid> templateIds)
		{
			GetResponse("Listings/DeleteBigcommerceTemplates", "templateIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(templateIds)) + "");
		}

		/// <summary>
        /// Use this call to delete eBay configurators.
        /// 
        ///  A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <param name="configs">Configs guid</param>
        public void DeleteeBayConfigurators(List<Guid> configs)
		{
			GetResponse("Listings/DeleteeBayConfigurators", "configs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(configs)) + "");
		}

		/// <summary>
        /// Use this call to delete a Ebay template. 
        /// </summary>
        /// <param name="templateIds"></param>
        public void DeleteEbayTemplates(IEnumerable<Guid> templateIds)
		{
			GetResponse("Listings/DeleteEbayTemplates", "templateIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(templateIds)) + "");
		}

		/// <summary>
        /// End eBay listings pending relist 
        /// </summary>
        public void EndListingsPendingRelist(EndListingsPendingRelistRequest request)
		{
			GetResponse("Listings/EndListingsPendingRelist", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Use this call to get eBay configurators by source and subsource 
        /// </summary>
        /// <returns>ebay configurators</returns>
        public GetEbayConfiguratorsResponse GetAllEbayConfigurators()
		{
			var response = GetResponse("Listings/GetAllEbayConfigurators", "");
            return JsonFormatter.ConvertFromJson<GetEbayConfiguratorsResponse>(response);
		}

		/// <summary>
        /// Use this call to get all Bigcommerce configurators.
        /// 
        ///  A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <returns>list of Bigcommerce configurators</returns>
        public IEnumerable<BigCommerceConfigurator> GetBigcommerceConfigurators()
		{
			var response = GetResponse("Listings/GetBigcommerceConfigurators", "");
            return JsonFormatter.ConvertFromJson<IEnumerable<BigCommerceConfigurator>>(response);
		}

		/// <summary>
        /// Use this call to return all created Big Commerce templates. 
        /// </summary>
        /// <param name="parameters">Object of TemplatesParameters</param>
        /// <returns>List of Bigcommerce Listings</returns>
        public PagedResult<BigCommerceListing> GetBigCommerceTemplates(GetTemplatesParameters parameters)
		{
			var response = GetResponse("Listings/GetBigCommerceTemplates", "parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "");
            return JsonFormatter.ConvertFromJson<PagedResult<BigCommerceListing>>(response);
		}

		/// <summary>
        /// Use this call to get eBay configurators.
        /// 
        ///  A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme.The same configurator can be used to list multiple items that share common details.To find out more about configurators you can visit our [documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <returns>ebay configurators</returns>
        public IEnumerable<EbayConfig> GeteBayConfigurators()
		{
			var response = GetResponse("Listings/GeteBayConfigurators", "");
            return JsonFormatter.ConvertFromJson<IEnumerable<EbayConfig>>(response);
		}

		/// <summary>
        /// Get eBay Listing Audit 
        /// </summary>
        public GetEbayListingAuditResponse GetEbayListingAudit(GetEbayListingAuditRequest request)
		{
			var response = GetResponse("Listings/GetEbayListingAudit", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetEbayListingAuditResponse>(response);
		}

		/// <summary>
        /// Use this call to return all created Ebay templates. 
        /// </summary>
        /// <param name="parameters">Object of TemplatesParameters</param>
        /// <returns>List of eBay Listings</returns>
        public PagedResult<EbayListing> GeteBayTemplates(GetTemplatesParameters parameters)
		{
			var response = GetResponse("Listings/GeteBayTemplates", "parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "");
            return JsonFormatter.ConvertFromJson<PagedResult<EbayListing>>(response);
		}

		/// <summary>
        /// Use this call to create templates in Linnworks and can also be used to push the template to a channel. This will create the template even if it returns null. This will also push the template to the channel depending on what the status is set as. 
        /// </summary>
        /// <param name="items">Bigcommerce templates</param>
        /// <param name="force">force</param>
        public void ProcessBigcommerceListings(List<BigCommerceListing> items,Boolean force)
		{
			GetResponse("Listings/ProcessBigcommerceListings", "items=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(items)) + "&force=" + force + "");
		}

		/// <summary>
        /// Use this call to create templates in Linnworks and can also be used to push the template to a channel. This will create the template even if it returns null. This will also push the template to the channel depending on what the status is set as. 
        /// </summary>
        /// <param name="items">eBay listings</param>
        /// <param name="force">force</param>
        /// <param name="action">action trigger for logging purposes E.g: "Update", "Create", "Process"</param>
        public void ProcesseBayListings(List<EbayListing> items,Boolean force,String action = "")
		{
			GetResponse("Listings/ProcesseBayListings", "items=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(items)) + "&force=" + force + "&action=" + System.Net.WebUtility.UrlEncode(action) + "");
		}

		/// <summary>
        /// Set eBay Listing Strike State 
        /// </summary>
        public void SetListingStrikeOffState(SetListingStrikeOffStateRequest request)
		{
			GetResponse("Listings/SetListingStrikeOffState", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Use this call to update BigCommerce configurators.
        /// 
        ///  A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <param name="configs">Configs to update</param>
        public void UpdateBigcommerceConfigurators(List<BigCommerceConfigurator> configs)
		{
			GetResponse("Listings/UpdateBigcommerceConfigurators", "configs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(configs)) + "");
		}

		/// <summary>
        /// Use this call to update eBay configurators.
        /// 
        ///  A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [documentation](https://docs.linnworks.com/articles/#!documentation/configurators) 
        /// </summary>
        /// <param name="configs">Configs to update</param>
        public void UpdateeBayConfigurators(List<EbayConfig> configs)
		{
			GetResponse("Listings/UpdateeBayConfigurators", "configs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(configs)) + "");
		} 
    }
}