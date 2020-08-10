using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class DashboardsController : BaseController, IDashboardsController
    {
        public DashboardsController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Use this call to retrieve Query Data report
        ///  Contact support with Query Data report name and we will provide you with parameters. 
        /// </summary>
        /// <param name="scriptId">Used to specify custom paged script id</param>
        /// <param name="parameters">Used to specify custom paged script conditional parameters</param>
        /// <param name="entriesPerPage">Used to specify number of entries per page in report</param>
        /// <param name="pageNumber">Used to specify custom paged script page number</param>
        /// <param name="cancellationToken">Terminates execution if task was cancelled on client</param>
        /// <returns>Custom script execution result</returns>
        public CustomScriptResult ExecuteCustomPagedScript(Int32 scriptId,List<ScriptParameter> parameters,Int32 entriesPerPage,Int32 pageNumber)
		{
			var response = GetResponse("Dashboards/ExecuteCustomPagedScript", "scriptId=" + scriptId + "&parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "");
            return JsonFormatter.ConvertFromJson<CustomScriptResult>(response);
		}

		/// <summary>
        /// Use this call to retrieve Query Data report
        ///  Contact support with Query Data report name and we will provide you with parameters. 
        /// </summary>
        /// <param name="scriptId">Used to specify custom paged script id</param>
        /// <param name="parameters">Used to specify custom paged script conditional parameters</param>
        /// <param name="entriesPerPage">Used to specify number of entries per page in report</param>
        /// <param name="pageNumber">Used to specify custom paged script page number</param>
        /// <param name="cancellationToken">Terminates execution if task was cancelled on client</param>
        /// <returns>Custom script execution result</returns>
        public CustomScriptResult ExecuteCustomPagedScript_Customer(Int32 scriptId,List<ScriptParameter> parameters,Int32 entriesPerPage,Int32 pageNumber)
		{
			var response = GetResponse("Dashboards/ExecuteCustomPagedScript_Customer", "scriptId=" + scriptId + "&parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "");
            return JsonFormatter.ConvertFromJson<CustomScriptResult>(response);
		}

		/// <summary>
        /// Use this call to retrieve a custom report from Query Data.
        ///  Apps using this call will not be allowed to Application Store. 
        /// </summary>
        /// <param name="script">Custom SQL script query text</param>
        /// <param name="cancellationToken">Terminates execution if task was cancelled on client</param>
        /// <returns>Custom script execution result (CustomScriptResult)</returns>
        public CustomScriptResult ExecuteCustomScriptQuery(ExecuteCustomScriptQueryRequest request)
		{
			var response = GetResponse("Dashboards/ExecuteCustomScriptQuery", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<CustomScriptResult>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "Stock info for categories in a specific location" 
        /// </summary>
        /// <param name="date">Used to specify report date or null for current period</param>
        /// <param name="locationId">Used to specify report location id</param>
        /// <returns>Sorted list of StockCategoryLocation</returns>
        public List<StockCategoryLocation> GetInventoryLocationCategoriesData(DateTime? date,Guid locationId)
		{
			var response = GetResponse("Dashboards/GetInventoryLocationCategoriesData", "date=" + System.Net.WebUtility.UrlEncode(date.HasValue ? date.Value.ToString("yyyy-MM-dd HH:mm:ss") : "null") + "&locationId=" + locationId + "");
            return JsonFormatter.ConvertFromJson<List<StockCategoryLocation>>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "Stock info for locations" 
        /// </summary>
        /// <param name="date">Used to specify report date or null for current period</param>
        /// <returns>Sorted list of StockItemLocations</returns>
        public List<StatsStockItemLocation> GetInventoryLocationData(DateTime? date)
		{
			var response = GetResponse("Dashboards/GetInventoryLocationData", "date=" + System.Net.WebUtility.UrlEncode(date.HasValue ? date.Value.ToString("yyyy-MM-dd HH:mm:ss") : "null") + "");
            return JsonFormatter.ConvertFromJson<List<StatsStockItemLocation>>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "Stock info for products in a specific category and location" 
        /// </summary>
        /// <param name="date">Used to specify report date or null for current period</param>
        /// <param name="locationId">Used to specify report location id</param>
        /// <param name="categoryId">Used to specify report category id</param>
        /// <param name="pageNumber">Used to specify report page number</param>
        /// <param name="entriesPerPage">Used to specify number of entries per page in report</param>
        /// <returns>PagedStockCategoryLocationProductResult</returns>
        public PagedStockCategoryLocationProductResult GetInventoryLocationProductsData(DateTime? date,Guid locationId,Guid categoryId,Int32 pageNumber,Int32 entriesPerPage)
		{
			var response = GetResponse("Dashboards/GetInventoryLocationProductsData", "date=" + System.Net.WebUtility.UrlEncode(date.HasValue ? date.Value.ToString("yyyy-MM-dd HH:mm:ss") : "null") + "&locationId=" + locationId + "&categoryId=" + categoryId + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "");
            return JsonFormatter.ConvertFromJson<PagedStockCategoryLocationProductResult>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "Low stock in location" 
        /// </summary>
        /// <param name="locationId">Used to specify report location id or null for combined</param>
        /// <param name="numRows">Used to specify number of returned rows</param>
        /// <returns>List of LowStockLevel</returns>
        public List<LowStockLevel> GetLowStockLevel(Guid? locationId,Int32? numRows)
		{
			var response = GetResponse("Dashboards/GetLowStockLevel", "locationId=" + locationId + "&numRows=" + numRows + "");
            return JsonFormatter.ConvertFromJson<List<LowStockLevel>>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "Performance through time chart" 
        /// </summary>
        /// <param name="period">Used to specify report number of months</param>
        /// <param name="timeScale">time scale</param>
        /// <returns>List of PerfomanceDetail</returns>
        public Dictionary<String,List<PerfomanceDetail>> GetPerformanceDetail(Int32 period,Int32 timeScale)
		{
			var response = GetResponse("Dashboards/GetPerformanceDetail", "period=" + period + "&timeScale=" + timeScale + "");
            return JsonFormatter.ConvertFromJson<Dictionary<String,List<PerfomanceDetail>>>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "Performance table" 
        /// </summary>
        /// <param name="period">Used to specify report number of months</param>
        /// <returns>List of PerfomanceData</returns>
        public List<PerfomanceData> GetPerformanceTableData(Int32 period)
		{
			var response = GetResponse("Dashboards/GetPerformanceTableData", "period=" + period + "");
            return JsonFormatter.ConvertFromJson<List<PerfomanceData>>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "Top ordered products" for top "10" products 
        /// </summary>
        /// <param name="type">Used to specify type of report: 1 - group result by quantity, 2 - group result by turnover</param>
        /// <param name="period">Used to specify report number of months</param>
        /// <param name="numRows">Number of rows required</param>
        /// <param name="orderStatus">Order status</param>
        /// <returns>List of TopProductData</returns>
        public List<TopProductData> GetTopProducts(TopProductsType type,Int32 period,Int32 numRows,Int32 orderStatus)
		{
			var response = GetResponse("Dashboards/GetTopProducts", "type=" + type.ToString() + "&period=" + period + "&numRows=" + numRows + "&orderStatus=" + orderStatus + "");
            return JsonFormatter.ConvertFromJson<List<TopProductData>>(response);
		} 
    }
}