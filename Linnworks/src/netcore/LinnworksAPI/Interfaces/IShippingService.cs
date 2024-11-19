using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IShippingServiceController
	{
		CancelOrderShippingLabelResponse CancelOrderShippingLabel(CancelOrderShippingLabelRequest request);
		GenericPagedResult<Consignment> GetConsignmentsByManifest(String vendor,String accountId,Int32 pkManifestId,Guid? externalManifestId,DateTime? manifestDate);
		GenericPagedResult<FiledManifest> GetFiledManifestsByVendor(String vendor,String vendorFriendlyName,DateTime from,DateTime to,Int32 pageNumber,Int32 entriesPerPage);
		List<System_ShippingAPI_Config> GetIntegrations();
		void PostShipmentUpload(PostShipmentUploadRequest request);
	} 
}