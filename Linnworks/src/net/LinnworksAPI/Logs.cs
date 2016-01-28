using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class LogsMethods
    {
        public static List<process_history> GetProgressHistoryStats(String jobType, DateTime startDate, DateTime endDate, Boolean errorsOnly, String orderField, Boolean sortAsc, Int32 PageNumber, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<process_history>>(Factory.GetResponse("Logs/GetProgressHistoryStats", "jobType=" + jobType + "&startDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(startDate) + "&endDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(endDate) + "&errorsOnly=" + errorsOnly + "&orderField=" + orderField + "&sortAsc=" + sortAsc + "&PageNumber=" + PageNumber + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Int32 GetProgressHistoryStatsCount(String jobType, DateTime startDate, DateTime endDate, Boolean errorsOnly, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Int32>(Factory.GetResponse("Logs/GetProgressHistoryStatsCount", "jobType=" + jobType + "&startDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(startDate) + "&endDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(endDate) + "&errorsOnly=" + errorsOnly + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<process_history> GetProgressHistoryLogs(String jobType, DateTime startDate, DateTime endDate, Boolean errorsOnly, Int32 PageNumber, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<process_history>>(Factory.GetResponse("Logs/GetProgressHistoryLogs", "jobType=" + jobType + "&startDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(startDate) + "&endDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(endDate) + "&errorsOnly=" + errorsOnly + "&PageNumber=" + PageNumber + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Int32 GetProgressHistoryLogsCount(String jobType, DateTime startDate, DateTime endDate, Boolean errorsOnly, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Int32>(Factory.GetResponse("Logs/GetProgressHistoryLogsCount", "jobType=" + jobType + "&startDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(startDate) + "&endDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(endDate) + "&errorsOnly=" + errorsOnly + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<process_error> GetProgressErrors(Int32 rowId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<process_error>>(Factory.GetResponse("Logs/GetProgressErrors", "rowId=" + rowId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<jobcode_register> GetJobTypes(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<jobcode_register>>(Factory.GetResponse("Logs/GetJobTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static String GetRootJobTypesCustomer(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Logs/GetRootJobTypesCustomer", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static jobcode_name_register GetChildrenJobTypesCustomer(String rootCategory, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<jobcode_name_register>(Factory.GetResponse("Logs/GetChildrenJobTypesCustomer", "rootCategory=" + rootCategory + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static String GetCSVProgressLog(String jobType, DateTime logDate, Int32 pkRowId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Logs/GetCSVProgressLog", "jobType=" + jobType + "&logDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(logDate) + "&pkRowId=" + pkRowId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<progress_log> GetProgressLog(String jobType, DateTime logDate, Int32 pkRowId, Int32 PageNumber, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<progress_log>>(Factory.GetResponse("Logs/GetProgressLog", "jobType=" + jobType + "&logDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(logDate) + "&pkRowId=" + pkRowId + "&PageNumber=" + PageNumber + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Int32 GetProgressLogCount(String jobType, DateTime logDate, Int32 pkRowId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Int32>(Factory.GetResponse("Logs/GetProgressLogCount", "jobType=" + jobType + "&logDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(logDate) + "&pkRowId=" + pkRowId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}