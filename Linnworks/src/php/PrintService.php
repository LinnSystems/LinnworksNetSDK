<?php
class PrintServiceMethods 
{ public static function CreatePDFfromJobForceTemplate($templateType,$IDs,$templateID,$parameters,$printerName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PrintService/CreatePDFfromJobForceTemplate", "templateType=" . $templateType . "&IDs=" . json_encode($IDs) . "&templateID=" . json_encode($templateID) . "&parameters=" . json_encode($parameters) . "&printerName=" . $printerName . "", $ApiToken, $ApiServer)); 
}

public static function CreatePDFfromJobForceTemplateStockIn($templateType,$PrintingKeys,$templateID,$parameters,$printerName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PrintService/CreatePDFfromJobForceTemplateStockIn", "templateType=" . $templateType . "&PrintingKeys=" . json_encode($PrintingKeys) . "&templateID=" . json_encode($templateID) . "&parameters=" . json_encode($parameters) . "&printerName=" . $printerName . "", $ApiToken, $ApiServer)); 
}

public static function CreatePDFfromJobForceTemplateWithQuantities($templateType,$IDsAndQuantities,$templateID,$parameters,$printerName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PrintService/CreatePDFfromJobForceTemplateWithQuantities", "templateType=" . $templateType . "&IDsAndQuantities=" . json_encode($IDsAndQuantities) . "&templateID=" . json_encode($templateID) . "&parameters=" . json_encode($parameters) . "&printerName=" . $printerName . "", $ApiToken, $ApiServer)); 
}

public static function CreateReturnShippingLabelsPDF($IDs,$orderItemIdsAndQuantities,$returnPostalServiceName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PrintService/CreateReturnShippingLabelsPDF", "IDs=" . json_encode($IDs) . "&orderItemIdsAndQuantities=" . json_encode($orderItemIdsAndQuantities) . "&returnPostalServiceName=" . $returnPostalServiceName . "", $ApiToken, $ApiServer)); 
}

public static function CreateReturnShippingLabelsPDFWithSKUs($referenceNum,$SKUsAndQuantities,$returnPostalServiceName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PrintService/CreateReturnShippingLabelsPDFWithSKUs", "referenceNum=" . $referenceNum . "&SKUsAndQuantities=" . json_encode($SKUsAndQuantities) . "&returnPostalServiceName=" . $returnPostalServiceName . "", $ApiToken, $ApiServer)); 
}

public static function GetTemplateList($templateType,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PrintService/GetTemplateList", "templateType=" . $templateType . "", $ApiToken, $ApiServer)); 
}

public static function GetUsersForPrinterConfig($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PrintService/GetUsersForPrinterConfig", "", $ApiToken, $ApiServer)); 
}

public static function PrintTemplatePreview($templateId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PrintService/PrintTemplatePreview", "templateId=" . $templateId . "", $ApiToken, $ApiServer)); 
}

public static function VP_GetPrinters($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PrintService/VP_GetPrinters", "", $ApiToken, $ApiServer)); 
} 
}
?>