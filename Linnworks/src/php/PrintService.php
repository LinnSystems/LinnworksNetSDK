<?php
class PrintServiceMethods 
{ public static function CreatePDFfromJobForceTemplate($templateType,$IDs,$templateID,$parameters,$printerName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PrintService/CreatePDFfromJobForceTemplate", "templateType=" . $templateType . "&IDs=" . json_encode($IDs) . "&templateID=" . json_encode($templateID) . "&parameters=" . json_encode($parameters) . "&printerName=" . $printerName . "", $ApiToken, $ApiServer)); 
}

public static function PrintTemplatePreview($templateId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PrintService/PrintTemplatePreview", "templateId=" . $templateId . "", $ApiToken, $ApiServer)); 
}

public static function GetTemplateList($templateType,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PrintService/GetTemplateList", "templateType=" . $templateType . "", $ApiToken, $ApiServer)); 
}

public static function VP_GetPrinters($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PrintService/VP_GetPrinters", "", $ApiToken, $ApiServer)); 
}

public static function GetUsersForPrinterConfig($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PrintService/GetUsersForPrinterConfig", "", $ApiToken, $ApiServer)); 
} 
}
?>