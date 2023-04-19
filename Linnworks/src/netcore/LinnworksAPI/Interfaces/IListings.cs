using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LinnworksAPI
{ 
    public interface IListingsController
	{
		void CreateAmazonConfigurators(List<AmazonConfig> configs);
		PagedResult<AmazonListing> CreateAmazonTemplates(ProcessTemplatesParameters parameters);
		void CreateBigcommerceConfigurators(List<BigCommerceConfigurator> configs);
		PagedResult<BigCommerceListing> CreateBigcommerceTemplates(ProcessTemplatesParameters parameters);
		void CreateeBayConfigurators(List<LinnLiveEbayConfig> configs);
		PagedResult<LinnLiveEbayListing> CreateEbayTemplates(ProcessTemplatesParameters parameters);
		void CreateMagentoConfigurators(List<MagentoConfig> configs);
		PagedResult<MagentoListing> CreateMagentoTemplates(ProcessTemplatesParameters parameters);
		void DeleteAmazonConfigurators(List<Guid> configs);
		void DeleteAmazonTemplates(IEnumerable<Guid> templateIds);
		void DeleteBigcommerceConfigurators(List<Guid> configs);
		void DeleteBigcommerceTemplates(IEnumerable<Guid> templateIds);
		void DeleteeBayConfigurators(List<Guid> configs);
		void DeleteEbayTemplates(IEnumerable<Guid> templateIds);
		void DeleteMagentoConfigurators(List<Guid> configs);
		void DeleteMagentoTemplates(List<Guid> templateIds);
		void EndListingsPendingRelist(EndListingsPendingRelistRequest request);
		IEnumerable<AmazonConfig> GetAmazonConfigurators();
		PagedResult<AmazonListing> GetAmazonTemplates(GetTemplatesParameters parameters);
		IEnumerable<BigCommerceConfigurator> GetBigcommerceConfigurators();
		PagedResult<BigCommerceListing> GetBigCommerceTemplates(GetTemplatesParameters parameters);
		IEnumerable<EbayConfig> GeteBayConfigurators();
		GetEbayListingAuditResponse GetEbayListingAudit(GetEbayListingAuditRequest request);
		PagedResult<LinnLiveEbayListing> GeteBayTemplates(GetTemplatesParameters parameters);
		IEnumerable<MagentoConfig> GetMagentoConfigurators();
		PagedResult<MagentoListing> GetMagentoTemplates(GetTemplatesParameters parameters);
		void ProcessAmazonListings(List<AmazonListing> items);
		void ProcessBigcommerceListings(List<BigCommerceListing> items,Boolean force);
		void ProcesseBayListings(List<EbayListing> items,Boolean force);
		void ProcessMagentoListings(List<MagentoListing> items,Boolean force);
		void SetListingStrikeOffState(SetListingStrikeOffStateRequest request);
		void UpdateAmazonConfigurators(List<AmazonConfig> configs);
		void UpdateBigcommerceConfigurators(List<BigCommerceConfigurator> configs);
		void UpdateeBayConfigurators(List<LinnLiveEbayConfig> configs);
		void UpdateMagentoConfigurators(List<MagentoConfig> configs);
	} 
}