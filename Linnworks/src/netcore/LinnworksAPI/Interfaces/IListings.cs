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
		void CreateBigcommerceConfigurators(List<BigCommerceConfigurator> configs);
		PagedResult<BigCommerceListing> CreateBigcommerceTemplates(ProcessTemplatesParameters parameters);
		void CreateeBayConfigurators(List<EbayConfig> configs);
		PagedResult<EbayListing> CreateEbayTemplates(ProcessTemplatesParameters parameters);
		void DeleteBigcommerceConfigurators(List<Guid> configs);
		void DeleteBigcommerceTemplates(IEnumerable<Guid> templateIds);
		void DeleteeBayConfigurators(List<Guid> configs);
		void DeleteEbayTemplates(IEnumerable<Guid> templateIds);
		void EndListingsPendingRelist(EndListingsPendingRelistRequest request);
		GetEbayConfiguratorsResponse GetAllEbayConfigurators();
		IEnumerable<BigCommerceConfigurator> GetBigcommerceConfigurators();
		PagedResult<BigCommerceListing> GetBigCommerceTemplates(GetTemplatesParameters parameters);
		IEnumerable<EbayConfig> GeteBayConfigurators();
		GetEbayListingAuditResponse GetEbayListingAudit(GetEbayListingAuditRequest request);
		PagedResult<EbayListing> GeteBayTemplates(GetTemplatesParameters parameters);
		void ProcessBigcommerceListings(List<BigCommerceListing> items,Boolean force);
		void ProcesseBayListings(List<EbayListing> items,Boolean force,String action = "");
		void SetListingStrikeOffState(SetListingStrikeOffStateRequest request);
		void UpdateBigcommerceConfigurators(List<BigCommerceConfigurator> configs);
		void UpdateeBayConfigurators(List<EbayConfig> configs);
	} 
}