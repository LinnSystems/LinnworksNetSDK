<?php
class OrderWorkflowMethods 
{ public static function CheckinUser($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("OrderWorkflow/CheckinUser", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function DeallocateOrderFromJob($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("OrderWorkflow/DeallocateOrderFromJob", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function GetGroup($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("OrderWorkflow/GetGroup", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function GetGroupList($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("OrderWorkflow/GetGroupList", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function GetJob($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("OrderWorkflow/GetJob", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function GetJobAudit($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("OrderWorkflow/GetJobAudit", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function GetJobByName($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("OrderWorkflow/GetJobByName", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function GetJobErrors($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("OrderWorkflow/GetJobErrors", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function GetPrintAttachment($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("OrderWorkflow/GetPrintAttachment", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function GetWorkflow($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("OrderWorkflow/GetWorkflow", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function Run($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("OrderWorkflow/Run", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function UpdateGroup($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("OrderWorkflow/UpdateGroup", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
} 
}
?>