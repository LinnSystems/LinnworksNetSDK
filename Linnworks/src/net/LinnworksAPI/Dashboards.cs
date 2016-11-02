using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class DashboardsMethods
    {
        public static List<LowStockLevel> GetLowStockLevel(Guid? locationId, Int32? numRows, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<LowStockLevel>>(Factory.GetResponse("Dashboards/GetLowStockLevel", "locationId=" + Newtonsoft.Json.JsonConvert.SerializeObject(locationId) + "&numRows=" + Newtonsoft.Json.JsonConvert.SerializeObject(numRows) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PerfomanceData> GetPerformanceTableData(Int32 period, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PerfomanceData>>(Factory.GetResponse("Dashboards/GetPerformanceTableData", "period=" + period + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Dictionary<String, List<PerfomanceDetail>> GetPerformanceDetail(Int32 period, Int32 timeScale, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String, List<PerfomanceDetail>>>(Factory.GetResponse("Dashboards/GetPerformanceDetail", "period=" + period + "&timeScale=" + timeScale + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<TopProductData> GetTopProducts(TopProductsType type, Int32 period, Int32 numRows, Int32 orderStatus, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<TopProductData>>(Factory.GetResponse("Dashboards/GetTopProducts", "type=" + type + "&period=" + period + "&numRows=" + numRows + "&orderStatus=" + orderStatus + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemLocation> GetInventoryLocationData(DateTime? date, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemLocation>>(Factory.GetResponse("Dashboards/GetInventoryLocationData", "date=" + Newtonsoft.Json.JsonConvert.SerializeObject(date) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockCategoryLocation> GetInventoryLocationCategoriesData(DateTime? date, Guid locationId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockCategoryLocation>>(Factory.GetResponse("Dashboards/GetInventoryLocationCategoriesData", "date=" + Newtonsoft.Json.JsonConvert.SerializeObject(date) + "&locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PagedStockCategoryLocationProductResult GetInventoryLocationProductsData(DateTime? date, Guid locationId, Guid categoryId, Int32 pageNumber, Int32 entriesPerPage, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PagedStockCategoryLocationProductResult>(Factory.GetResponse("Dashboards/GetInventoryLocationProductsData", "date=" + Newtonsoft.Json.JsonConvert.SerializeObject(date) + "&locationId=" + locationId + "&categoryId=" + categoryId + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static CustomScriptResult ExecuteCustomPagedScript(Int32 scriptId, ScriptParameter parameters, Int32 entriesPerPage, Int32 pageNumber, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CustomScriptResult>(Factory.GetResponse("Dashboards/ExecuteCustomPagedScript", "scriptId=" + scriptId + "&parameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(parameters) + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}