using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IDashboardsController
	{
		CustomScriptResult ExecuteCustomPagedScript(Int32 scriptId,List<ScriptParameter> parameters,Int32 entriesPerPage,Int32 pageNumber);
		CustomScriptResult ExecuteCustomPagedScript_Customer(Int32 scriptId,List<ScriptParameter> parameters,Int32 entriesPerPage,Int32 pageNumber);
		CustomScriptResult ExecuteCustomScriptQuery(ExecuteCustomScriptQueryRequest request);
		List<StockCategoryLocation> GetInventoryLocationCategoriesData(DateTime? date,Guid locationId);
		List<StatsStockItemLocation> GetInventoryLocationData(DateTime? date);
		PagedStockCategoryLocationProductResult GetInventoryLocationProductsData(DateTime? date,Guid locationId,Guid categoryId,Int32 pageNumber,Int32 entriesPerPage);
		List<LowStockLevel> GetLowStockLevel(Guid? locationId,Int32? numRows);
		Dictionary<String,List<PerfomanceDetail>> GetPerformanceDetail(Int32 period,Int32 timeScale);
		List<PerfomanceData> GetPerformanceTableData(Int32 period);
		List<TopProductData> GetTopProducts(TopProductsType type,Int32 period,Int32 numRows,Int32 orderStatus);
	} 
}