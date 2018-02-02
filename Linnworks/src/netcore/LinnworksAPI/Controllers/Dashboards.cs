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

        public CustomScriptResult ExecuteCustomPagedScript(Int32 scriptId,ScriptParameter[] parameters,Int32 entriesPerPage,Int32 pageNumber)
		{
			var response = GetResponse("Dashboards/ExecuteCustomPagedScript", "scriptId=" + scriptId + "&parameters=" + JsonFormatter.ConvertToJson(parameters) + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "");
            return JsonFormatter.ConvertFromJson<CustomScriptResult>(response);
		}

		/// <summary>
        /// Use this call to retrieve a custom report from Query Data.
        ///  Apps using this call will not be allowed to Application Store. 
        /// </summary>
        /// <param name="script">Custom SQL script query text</param>
        /// <returns>Custom script execution result (CustomScriptResult)</returns>
        public CustomScriptResult ExecuteCustomScriptQuery(String script)
		{
			var response = GetResponse("Dashboards/ExecuteCustomScriptQuery", "script=" + script + "");
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
			var response = GetResponse("Dashboards/GetInventoryLocationCategoriesData", "date=" + JsonFormatter.ConvertToJson(date) + "&locationId=" + locationId + "");
            return JsonFormatter.ConvertFromJson<List<StockCategoryLocation>>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "Stock info for locations" 
        /// </summary>
        /// <param name="date">Used to specify report date or null for current period</param>
        /// <returns>Sorted list of StockItemLocations</returns>
        public List<StockItemLocation> GetInventoryLocationData(DateTime? date)
		{
			var response = GetResponse("Dashboards/GetInventoryLocationData", "date=" + JsonFormatter.ConvertToJson(date) + "");
            return JsonFormatter.ConvertFromJson<List<StockItemLocation>>(response);
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
			var response = GetResponse("Dashboards/GetInventoryLocationProductsData", "date=" + JsonFormatter.ConvertToJson(date) + "&locationId=" + locationId + "&categoryId=" + categoryId + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "");
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
			var response = GetResponse("Dashboards/GetLowStockLevel", "locationId=" + JsonFormatter.ConvertToJson(locationId) + "&numRows=" + JsonFormatter.ConvertToJson(numRows) + "");
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