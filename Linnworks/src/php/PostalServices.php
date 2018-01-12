<?php
class PostalServicesMethods 
{ public static function CreatePostalService($PostalServiceDetails,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PostalServices/CreatePostalService", "PostalServiceDetails=" . json_encode($PostalServiceDetails) . "", $ApiToken, $ApiServer)); 
}

public static function DeletePostalService($idToDelete,$ApiToken, $ApiServer)
{
 Factory::GetResponse("PostalServices/DeletePostalService", "idToDelete=" . $idToDelete . "", $ApiToken, $ApiServer); 
}

public static function GetChannelLinks($postalServiceId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PostalServices/GetChannelLinks", "postalServiceId=" . $postalServiceId . "", $ApiToken, $ApiServer)); 
}

public static function GetPostalServices($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PostalServices/GetPostalServices", "", $ApiToken, $ApiServer)); 
}

public static function UpdatePostalService($PostalServiceDetails,$ApiToken, $ApiServer)
{
 Factory::GetResponse("PostalServices/UpdatePostalService", "PostalServiceDetails=" . json_encode($PostalServiceDetails) . "", $ApiToken, $ApiServer); 
} 
}
?>