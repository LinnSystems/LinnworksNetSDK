<?php
class PaymentsMethods 
{ public static function GetCheckoutInformation($Request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Payments/GetCheckoutInformation", "Request=" . json_encode($Request) . "", $ApiToken, $ApiServer)); 
}

public static function CompleteCheckoutPayment($Request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Payments/CompleteCheckoutPayment", "Request=" . json_encode($Request) . "", $ApiToken, $ApiServer)); 
} 
}
?>