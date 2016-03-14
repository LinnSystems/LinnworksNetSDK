<?php
class LogsMethods 
{ public static function GetProgressHistoryStats($jobType,$startDate,$endDate,$errorsOnly,$orderField,$sortAsc,$PageNumber,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Logs/GetProgressHistoryStats", "jobType=" . $jobType . "&startDate=" . json_encode($startDate) . "&endDate=" . json_encode($endDate) . "&errorsOnly=" . $errorsOnly . "&orderField=" . $orderField . "&sortAsc=" . $sortAsc . "&PageNumber=" . $PageNumber . "", $ApiToken, $ApiServer)); 
}

public static function GetProgressHistoryStatsCount($jobType,$startDate,$endDate,$errorsOnly,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Logs/GetProgressHistoryStatsCount", "jobType=" . $jobType . "&startDate=" . json_encode($startDate) . "&endDate=" . json_encode($endDate) . "&errorsOnly=" . $errorsOnly . "", $ApiToken, $ApiServer)); 
}

public static function GetProgressHistoryLogs($jobType,$startDate,$endDate,$errorsOnly,$PageNumber,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Logs/GetProgressHistoryLogs", "jobType=" . $jobType . "&startDate=" . json_encode($startDate) . "&endDate=" . json_encode($endDate) . "&errorsOnly=" . $errorsOnly . "&PageNumber=" . $PageNumber . "", $ApiToken, $ApiServer)); 
}

public static function GetProgressHistoryLogsCount($jobType,$startDate,$endDate,$errorsOnly,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Logs/GetProgressHistoryLogsCount", "jobType=" . $jobType . "&startDate=" . json_encode($startDate) . "&endDate=" . json_encode($endDate) . "&errorsOnly=" . $errorsOnly . "", $ApiToken, $ApiServer)); 
}

public static function GetProgressErrors($rowId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Logs/GetProgressErrors", "rowId=" . $rowId . "", $ApiToken, $ApiServer)); 
}

public static function GetJobTypes($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Logs/GetJobTypes", "", $ApiToken, $ApiServer)); 
}

public static function GetRootJobTypesCustomer($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Logs/GetRootJobTypesCustomer", "", $ApiToken, $ApiServer)); 
}

public static function GetChildrenJobTypesCustomer($rootCategory,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Logs/GetChildrenJobTypesCustomer", "rootCategory=" . $rootCategory . "", $ApiToken, $ApiServer)); 
}

public static function GetCSVProgressLog($jobType,$logDate,$pkRowId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Logs/GetCSVProgressLog", "jobType=" . $jobType . "&logDate=" . json_encode($logDate) . "&pkRowId=" . $pkRowId . "", $ApiToken, $ApiServer)); 
}

public static function GetProgressLog($jobType,$logDate,$pkRowId,$PageNumber,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Logs/GetProgressLog", "jobType=" . $jobType . "&logDate=" . json_encode($logDate) . "&pkRowId=" . $pkRowId . "&PageNumber=" . $PageNumber . "", $ApiToken, $ApiServer)); 
}

public static function GetProgressLogCount($jobType,$logDate,$pkRowId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Logs/GetProgressLogCount", "jobType=" . $jobType . "&logDate=" . json_encode($logDate) . "&pkRowId=" . $pkRowId . "", $ApiToken, $ApiServer)); 
} 
}
?>