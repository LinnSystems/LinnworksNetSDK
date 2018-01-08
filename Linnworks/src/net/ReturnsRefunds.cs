using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{
	public static class ReturnsRefundsMethods 
	{ 
		private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ"};
 		public static List<RefundOrder> GetRefundOrders(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<RefundOrder>>(Factory.GetResponse("ReturnsRefunds/GetRefundOrders", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<RefundInfo> GetRefunds(Guid ApiToken, String ApiServer,Guid pkOrderId,Guid? refundReference = null)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<RefundInfo>>(Factory.GetResponse("ReturnsRefunds/GetRefunds", "pkOrderId=" + pkOrderId + "&refundReference=" + Newtonsoft.Json.JsonConvert.SerializeObject(refundReference, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<BookedReturnsExchangeOrder> GetBookedReturnsExchangeOrders(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<BookedReturnsExchangeOrder>>(Factory.GetResponse("ReturnsRefunds/GetBookedReturnsExchangeOrders", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<BookedReturnsExchangeItem> GetBookedReturnsExchangeItems(Guid pkOrderId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<BookedReturnsExchangeItem>>(Factory.GetResponse("ReturnsRefunds/GetBookedReturnsExchangeItems", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void DeleteBookedOrder(Guid pkOrderId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("ReturnsRefunds/DeleteBookedOrder", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer); 
		}

		public static void ActionBookedOrder(Guid pkOrderId,List<BookedReturnsExchangeItem> bookedItems,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("ReturnsRefunds/ActionBookedOrder", "pkOrderId=" + pkOrderId + "&bookedItems=" + Newtonsoft.Json.JsonConvert.SerializeObject(bookedItems, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteBookedItem(Guid pkOrderId,Int32 pkReturnId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("ReturnsRefunds/DeleteBookedItem", "pkOrderId=" + pkOrderId + "&pkReturnId=" + pkReturnId + "", ApiToken, ApiServer); 
		}

		public static void RefundOrder(Guid ApiToken, String ApiServer,Guid pkOrderId,Guid? refundReference = null)		{
			Factory.GetResponse("ReturnsRefunds/RefundOrder", "pkOrderId=" + pkOrderId + "&refundReference=" + Newtonsoft.Json.JsonConvert.SerializeObject(refundReference, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static List<WarehouseLocation> GetWarehouseLocations(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<WarehouseLocation>>(Factory.GetResponse("ReturnsRefunds/GetWarehouseLocations", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void EditBookedItemInfo(Guid pkOrderId,BookedReturnsExchangeItem bookedReturnsExchangeItem,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("ReturnsRefunds/EditBookedItemInfo", "pkOrderId=" + pkOrderId + "&bookedReturnsExchangeItem=" + Newtonsoft.Json.JsonConvert.SerializeObject(bookedReturnsExchangeItem, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeletePendingRefundItem(Guid fkOrderId,Guid pkRefundRowId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("ReturnsRefunds/DeletePendingRefundItem", "fkOrderId=" + fkOrderId + "&pkRefundRowId=" + pkRefundRowId + "", ApiToken, ApiServer); 
		}

		public static Double GetTotalRefunds(Guid fkOrderId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Double>(Factory.GetResponse("ReturnsRefunds/GetTotalRefunds", "fkOrderId=" + fkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static GenericPagedResult<ReturnsRefundsWeb> SearchReturnsRefundsPaged(Guid ApiToken, String ApiServer,DateTime? from,DateTime? to,ReturnsRefundsSearchDateType dateType,String searchField,Boolean exactMatch,String searchTerm,Int32 pageNum,Int32 numEntriesPerPage,HistoryType historyType = HistoryType.RETURNS)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericPagedResult<ReturnsRefundsWeb>>(Factory.GetResponse("ReturnsRefunds/SearchReturnsRefundsPaged", "from=" + Newtonsoft.Json.JsonConvert.SerializeObject(from, serializerSettings) + "&to=" + Newtonsoft.Json.JsonConvert.SerializeObject(to, serializerSettings) + "&dateType=" + dateType + "&searchField=" + searchField + "&exactMatch=" + exactMatch + "&searchTerm=" + searchTerm + "&pageNum=" + pageNum + "&numEntriesPerPage=" + numEntriesPerPage + "&historyType=" + historyType + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static String CreateReturnsRefundsCSV(Guid ApiToken, String ApiServer,DateTime? from,DateTime? to,ReturnsRefundsSearchDateType dateType,String searchField,Boolean exactMatch,String searchTerm,String sortColumn,Boolean sortDirection,HistoryType historyType = HistoryType.RETURNS)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("ReturnsRefunds/CreateReturnsRefundsCSV", "from=" + Newtonsoft.Json.JsonConvert.SerializeObject(from, serializerSettings) + "&to=" + Newtonsoft.Json.JsonConvert.SerializeObject(to, serializerSettings) + "&dateType=" + dateType + "&searchField=" + searchField + "&exactMatch=" + exactMatch + "&searchTerm=" + searchTerm + "&sortColumn=" + sortColumn + "&sortDirection=" + sortDirection + "&historyType=" + historyType + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<SearchField> GetSearchTypes(HistoryType historyType,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<SearchField>>(Factory.GetResponse("ReturnsRefunds/GetSearchTypes", "historyType=" + historyType + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		} 
	}
}