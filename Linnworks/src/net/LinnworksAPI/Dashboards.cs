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
	public static class DashboardsMethods 
	{ 
		private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ"};
 		public static CustomScriptResult ExecuteCustomPagedScript(Int32 scriptId,ScriptParameter[] parameters,Int32 entriesPerPage,Int32 pageNumber,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<CustomScriptResult>(Factory.GetResponse("Dashboards/ExecuteCustomPagedScript", "scriptId=" + scriptId + "&parameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(parameters, serializerSettings) + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static CustomScriptResult ExecuteCustomScriptQuery(String script,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<CustomScriptResult>(Factory.GetResponse("Dashboards/ExecuteCustomScriptQuery", "script=" + script + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockCategoryLocation> GetInventoryLocationCategoriesData(DateTime? date,Guid locationId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockCategoryLocation>>(Factory.GetResponse("Dashboards/GetInventoryLocationCategoriesData", "date=" + Newtonsoft.Json.JsonConvert.SerializeObject(date, serializerSettings) + "&locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemLocation> GetInventoryLocationData(DateTime? date,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemLocation>>(Factory.GetResponse("Dashboards/GetInventoryLocationData", "date=" + Newtonsoft.Json.JsonConvert.SerializeObject(date, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static PagedStockCategoryLocationProductResult GetInventoryLocationProductsData(DateTime? date,Guid locationId,Guid categoryId,Int32 pageNumber,Int32 entriesPerPage,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<PagedStockCategoryLocationProductResult>(Factory.GetResponse("Dashboards/GetInventoryLocationProductsData", "date=" + Newtonsoft.Json.JsonConvert.SerializeObject(date, serializerSettings) + "&locationId=" + locationId + "&categoryId=" + categoryId + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<LowStockLevel> GetLowStockLevel(Guid? locationId,Int32? numRows,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<LowStockLevel>>(Factory.GetResponse("Dashboards/GetLowStockLevel", "locationId=" + Newtonsoft.Json.JsonConvert.SerializeObject(locationId, serializerSettings) + "&numRows=" + Newtonsoft.Json.JsonConvert.SerializeObject(numRows, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Dictionary<String,List<PerfomanceDetail>> GetPerformanceDetail(Int32 period,Int32 timeScale,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String,List<PerfomanceDetail>>>(Factory.GetResponse("Dashboards/GetPerformanceDetail", "period=" + period + "&timeScale=" + timeScale + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<PerfomanceData> GetPerformanceTableData(Int32 period,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PerfomanceData>>(Factory.GetResponse("Dashboards/GetPerformanceTableData", "period=" + period + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<TopProductData> GetTopProducts(TopProductsType type,Int32 period,Int32 numRows,Int32 orderStatus,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<TopProductData>>(Factory.GetResponse("Dashboards/GetTopProducts", "type=" + type + "&period=" + period + "&numRows=" + numRows + "&orderStatus=" + orderStatus + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		} 
	}
}