var Logs =
{
	// http://apidoc.linnworks.net/#/Logs-GetProgressHistoryStats
	GetProgressHistoryStats: function(jobType,startDate,endDate,errorsOnly,orderField,sortAsc,PageNumber,token, server)
	{
		return Factory.GetResponse("Logs/GetProgressHistoryStats", token, server, "jobType=" + jobType + "&startDate=" + JSON.stringify(startDate) + "&endDate=" + JSON.stringify(endDate) + "&errorsOnly=" + errorsOnly + "&orderField=" + orderField + "&sortAsc=" + sortAsc + "&PageNumber=" + PageNumber +"");
	},
	// http://apidoc.linnworks.net/#/Logs-GetProgressHistoryStatsCount
	GetProgressHistoryStatsCount: function(jobType,startDate,endDate,errorsOnly,token, server)
	{
		return Factory.GetResponse("Logs/GetProgressHistoryStatsCount", token, server, "jobType=" + jobType + "&startDate=" + JSON.stringify(startDate) + "&endDate=" + JSON.stringify(endDate) + "&errorsOnly=" + errorsOnly +"");
	},
	// http://apidoc.linnworks.net/#/Logs-GetProgressHistoryLogs
	GetProgressHistoryLogs: function(jobType,startDate,endDate,errorsOnly,PageNumber,token, server)
	{
		return Factory.GetResponse("Logs/GetProgressHistoryLogs", token, server, "jobType=" + jobType + "&startDate=" + JSON.stringify(startDate) + "&endDate=" + JSON.stringify(endDate) + "&errorsOnly=" + errorsOnly + "&PageNumber=" + PageNumber +"");
	},
	// http://apidoc.linnworks.net/#/Logs-GetProgressHistoryLogsCount
	GetProgressHistoryLogsCount: function(jobType,startDate,endDate,errorsOnly,token, server)
	{
		return Factory.GetResponse("Logs/GetProgressHistoryLogsCount", token, server, "jobType=" + jobType + "&startDate=" + JSON.stringify(startDate) + "&endDate=" + JSON.stringify(endDate) + "&errorsOnly=" + errorsOnly +"");
	},
	// http://apidoc.linnworks.net/#/Logs-GetProgressErrors
	GetProgressErrors: function(rowId,token, server)
	{
		return Factory.GetResponse("Logs/GetProgressErrors", token, server, "rowId=" + rowId +"");
	},
	// http://apidoc.linnworks.net/#/Logs-GetJobTypes
	GetJobTypes: function(token, server)
	{
		return Factory.GetResponse("Logs/GetJobTypes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Logs-GetRootJobTypesCustomer
	GetRootJobTypesCustomer: function(token, server)
	{
		return Factory.GetResponse("Logs/GetRootJobTypesCustomer", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Logs-GetChildrenJobTypesCustomer
	GetChildrenJobTypesCustomer: function(rootCategory,token, server)
	{
		return Factory.GetResponse("Logs/GetChildrenJobTypesCustomer", token, server, "rootCategory=" + rootCategory +"");
	},
	// http://apidoc.linnworks.net/#/Logs-GetCSVProgressLog
	GetCSVProgressLog: function(jobType,logDate,pkRowId,token, server)
	{
		return Factory.GetResponse("Logs/GetCSVProgressLog", token, server, "jobType=" + jobType + "&logDate=" + JSON.stringify(logDate) + "&pkRowId=" + pkRowId +"");
	},
	// http://apidoc.linnworks.net/#/Logs-GetProgressLog
	GetProgressLog: function(jobType,logDate,pkRowId,PageNumber,token, server)
	{
		return Factory.GetResponse("Logs/GetProgressLog", token, server, "jobType=" + jobType + "&logDate=" + JSON.stringify(logDate) + "&pkRowId=" + pkRowId + "&PageNumber=" + PageNumber +"");
	},
	// http://apidoc.linnworks.net/#/Logs-GetProgressLogCount
	GetProgressLogCount: function(jobType,logDate,pkRowId,token, server)
	{
		return Factory.GetResponse("Logs/GetProgressLogCount", token, server, "jobType=" + jobType + "&logDate=" + JSON.stringify(logDate) + "&pkRowId=" + pkRowId +"");
	},
};
