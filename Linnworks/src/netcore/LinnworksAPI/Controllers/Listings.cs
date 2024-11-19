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
        /// Use this call to create Amazon configurators.
        /// 
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
        /// </summary>
        /// <param name="configs">Configs to create</param>
        public void CreateAmazonConfigurators(List<AmazonConfig> configs)
		{
			GetResponse("Listings/CreateAmazonConfigurators", "configs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(configs)) + "");
		}

		/// <summary>
        /// Use this call to return a template based on the configurator setting you have requested. This allows you to see the template which can then be  retuned to the ProcessAmazonListing endpoint which will build the listing. 
        /// </summary>
        /// <param name="parameters">Object of TemplatesParameters</param>
        /// <returns>List of Amazon Listings</returns>
        public PagedResult<AmazonListing> CreateAmazonTemplates(ProcessTemplatesParameters parameters)
		{
			var response = GetResponse("Listings/CreateAmazonTemplates", "parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "");
            return JsonFormatter.ConvertFromJson<PagedResult<AmazonListing>>(response);
		}

		/// <summary>
        /// Use this call to create BigCommerce configurators.
        /// 
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
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
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme.The same configurator can be used to list multiple items that share common details.To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
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
        /// Use this call to create Magento configurators.
        /// 
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
        /// </summary>
        /// <param name="configs">Configs to create</param>
        public void CreateMagentoConfigurators(List<MagentoConfig> configs)
		{
			GetResponse("Listings/CreateMagentoConfigurators", "configs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(configs)) + "");
		}

		/// <summary>
        /// Use this call to return a template based on the configurator setting you have requested. This allows you to see the template which can then be  retuned to the ProcessMagentoListing endpoint which will build the listing. 
        /// </summary>
        /// <param name="parameters">Object of TemplatesParameters</param>
        /// <returns>List of Magento Listings</returns>
        public PagedResult<MagentoListing> CreateMagentoTemplates(ProcessTemplatesParameters parameters)
		{
			var response = GetResponse("Listings/CreateMagentoTemplates", "parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "");
            return JsonFormatter.ConvertFromJson<PagedResult<MagentoListing>>(response);
		}

		/// <summary>
        /// Use this call to delete Amazon configurators.
        /// 
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
        /// </summary>
        /// <param name="configs">Configs guid</param>
        public void DeleteAmazonConfigurators(List<Guid> configs)
		{
			GetResponse("Listings/DeleteAmazonConfigurators", "configs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(configs)) + "");
		}

		/// <summary>
        /// Use this call to delete a Amazon template. 
        /// </summary>
        /// <param name="templateIds"></param>
        public void DeleteAmazonTemplates(IEnumerable<Guid> templateIds)
		{
			GetResponse("Listings/DeleteAmazonTemplates", "templateIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(templateIds)) + "");
		}

		/// <summary>
        /// Use this call to delete BigCommerce configurators.
        /// 
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
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
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
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
        /// Use this call to delete Magento configurators.
        /// 
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
        /// </summary>
        /// <param name="configs">Configs guid</param>
        public void DeleteMagentoConfigurators(List<Guid> configs)
		{
			GetResponse("Listings/DeleteMagentoConfigurators", "configs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(configs)) + "");
		}

		/// <summary>
        /// Use this call to delete a Magento template. 
        /// </summary>
        /// <param name="templateIds"></param>
        public void DeleteMagentoTemplates(List<Guid> templateIds)
		{
			GetResponse("Listings/DeleteMagentoTemplates", "templateIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(templateIds)) + "");
		}

		/// <summary>
        /// End eBay listings pending relist 
        /// </summary>
        public void EndListingsPendingRelist(EndListingsPendingRelistRequest request)
		{
			GetResponse("Listings/EndListingsPendingRelist", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Use this call to get Amazon configurators.
        /// 
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
        /// </summary>
        /// <returns>List of all Amazon configurators</returns>
        public IEnumerable<AmazonConfig> GetAmazonConfigurators()
		{
			var response = GetResponse("Listings/GetAmazonConfigurators", "");
            return JsonFormatter.ConvertFromJson<IEnumerable<AmazonConfig>>(response);
		}

		/// <summary>
        /// Use this call to return all created Amazon templates. 
        /// </summary>
        /// <param name="parameters">Object of TemplatesParameters</param>
        /// <returns>List of Amazon Listings</returns>
        public PagedResult<AmazonListing> GetAmazonTemplates(GetTemplatesParameters parameters)
		{
			var response = GetResponse("Listings/GetAmazonTemplates", "parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "");
            return JsonFormatter.ConvertFromJson<PagedResult<AmazonListing>>(response);
		}

		/// <summary>
        /// Use this call to get all Bigcommerce configurators.
        /// 
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
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
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme.The same configurator can be used to list multiple items that share common details.To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
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
        /// Use this call to get all Magento configurators.
        /// 
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
        /// </summary>
        /// <returns>list of Magento configurators</returns>
        public IEnumerable<MagentoConfig> GetMagentoConfigurators()
		{
			var response = GetResponse("Listings/GetMagentoConfigurators", "");
            return JsonFormatter.ConvertFromJson<IEnumerable<MagentoConfig>>(response);
		}

		/// <summary>
        /// Use this call to return all created Magento templates. 
        /// </summary>
        /// <param name="parameters">Object of GetMagentoTemplatesParameters</param>
        /// <returns>List of Magento Listings</returns>
        public PagedResult<MagentoListing> GetMagentoTemplates(GetTemplatesParameters parameters)
		{
			var response = GetResponse("Listings/GetMagentoTemplates", "parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "");
            return JsonFormatter.ConvertFromJson<PagedResult<MagentoListing>>(response);
		}

		/// <summary>
        /// Use this call to create templates in Linnworks and can also be used to push the template to a channel. This will create the template even if it returns null. This will also push the template to the channel depending on what the status is set as. 
        /// Amazon Listing Statuses:
        /// NOT_LISTED,
        /// OK,
        /// CREATING(push to channel),
        /// UPDATING,
        /// UPDATING_PRICE,
        /// UPDATING_QUANTITY,
        /// UPDATING_IMAGES,
        /// CREATING_VARIATION,
        /// DELETING,
        /// SEARCHING_FOR_MATCHES,
        /// UPDATING_SHIPPING 
        /// </summary>
        /// <param name="items">Amazon listings</param>
        public void ProcessAmazonListings(List<AmazonListing> items)
		{
			GetResponse("Listings/ProcessAmazonListings", "items=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(items)) + "");
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
        public void ProcesseBayListings(List<EbayListing> items,Boolean force)
		{
			GetResponse("Listings/ProcesseBayListings", "items=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(items)) + "&force=" + force + "");
		}

		/// <summary>
        /// Use this call to create templates in Linnworks and can also be used to push the template to a channel. This will create the template even if it returns null. This will also push the template to the channel depending on what the status is set as. 
        /// </summary>
        /// <param name="items">Magento listings</param>
        /// <param name="force">force</param>
        public void ProcessMagentoListings(List<MagentoListing> items,Boolean force)
		{
			GetResponse("Listings/ProcessMagentoListings", "items=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(items)) + "&force=" + force + "");
		}

		/// <summary>
        /// Set eBay Listing Strike State 
        /// </summary>
        public void SetListingStrikeOffState(SetListingStrikeOffStateRequest request)
		{
			GetResponse("Listings/SetListingStrikeOffState", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Use this call to update Amazon configurators.
        /// 
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
        /// </summary>
        /// <param name="configs">Configs to update</param>
        public void UpdateAmazonConfigurators(List<AmazonConfig> configs)
		{
			GetResponse("Listings/UpdateAmazonConfigurators", "configs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(configs)) + "");
		}

		/// <summary>
        /// Use this call to update BigCommerce configurators.
        /// 
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
        /// </summary>
        /// <param name="configs">Configs to update</param>
        public void UpdateBigcommerceConfigurators(List<BigCommerceConfigurator> configs)
		{
			GetResponse("Listings/UpdateBigcommerceConfigurators", "configs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(configs)) + "");
		}

		/// <summary>
        /// Use this call to update eBay configurators.
        /// 
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
        /// </summary>
        /// <param name="configs">Configs to update</param>
        public void UpdateeBayConfigurators(List<EbayConfig> configs)
		{
			GetResponse("Listings/UpdateeBayConfigurators", "configs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(configs)) + "");
		}

		/// <summary>
        /// Use this call to update Magento configurators.
        /// 
        /// A configurator hosts common details for listings such as listing type, return policy, payment methods, shipping info, attributes, listing categories, etc. Configurators offer an efficient way of creating listings in bulk that follow a common theme. The same configurator can be used to list multiple items that share common details. To find out more about configurators you can visit our [url=https://docs.linnworks.com/articles/#!documentation/configurators]documentation[/url] 
        /// </summary>
        /// <param name="configs">Configs to update</param>
        public void UpdateMagentoConfigurators(List<MagentoConfig> configs)
		{
			GetResponse("Listings/UpdateMagentoConfigurators", "configs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(configs)) + "");
		} 
    }
}