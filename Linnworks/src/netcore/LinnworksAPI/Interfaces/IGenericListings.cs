using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IGenericListingsController
	{
		CreateConfiguratorResponse CreateConfigurator(CreateConfiguratorRequest request);
		CreateTemplatesResponse CreateTemplates(CreateTemplatesRequest request);
		DeleteConfiguratorsResponse DeleteConfigurators(DeleteConfiguratorsRequest request);
		GetConfiguratorDataResponse GetConfiguratorData(GetConfiguratorDataRequest request);
		GetConfiguratorDescriptionResponse GetConfiguratorDescription(GetConfiguratorDataRequest request);
		GetConfiguratorsInfoResponse GetConfiguratorsInfoPaged(GetConfiguratorsInfoPagedRequest request);
		OpenTemplatesByInventoryResponse OpenTemplatesByInventory(OpenTemplatesByInventoryRequest request);
		ProcessTemplatesResponse ProcessTemplates(ProcessTemplatesRequest request);
		SaveConfiguratorDataResponse SaveConfiguratorData(SaveConfiguratorDataRequest request);
		SaveConfiguratorDescriptionResponse SaveConfiguratorDescription(SaveConfiguratorDescriptionRequest request);
		SaveConfiguratorFieldsResponse SaveConfiguratorFields(SaveConfiguratorFieldsRequest request);
		SaveTemplateFieldsResponse SaveTemplateFields(SaveTemplateFieldsRequest request);
	} 
}