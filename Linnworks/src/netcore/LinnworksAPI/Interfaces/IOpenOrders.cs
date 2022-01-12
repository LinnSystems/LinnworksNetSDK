using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LinnworksAPI
{ 
    public interface IOpenOrdersController
	{
		AssignResult AssignOrderIdentifier(ChangeOrderIdentifierRequest request);
		AssignStockToOrdersResponse<OrderItemBatchExtended,Guid> AssignStockToOrders(AssignStockToOrdersRequest request);
		AssignStockToOrdersResponse<Int32,Int32> DeleteAssignedStock(ClearStockAssignmentRequest request);
		void DeleteIdentifier(DeleteIdentifiersRequest request);
		GetAvailableChannelsResponse GetAvailableChannels();
		List<Identifier> GetIdentifiers();
		List<OrderIdentifier> GetIdentifiersByOrderIds(GetOrderIdentifierRequest request);
		GenericPagedResult<Guid> GetOpenOrderIds(GetOpenOrdersRequest request);
		GetOpenOrdersDetailsResponse GetOpenOrdersDetails(GetOpenOrdersDetailsRequest request);
		GetOrderItemIndicatorResponse GetOrderItemIndicators(GetOrderItemIndicatorRequest request);
		List<OrderViewStats> GetViewStats(GetViewStatsRequest request);
		Identifier SaveIdentifier(SaveIdentifiersRequest request);
		SearchOrdersResponse SearchOrders(SearchOrdersRequest request);
		AssignResult UnassignOrderIdentifier(ChangeOrderIdentifierRequest request);
	} 
}