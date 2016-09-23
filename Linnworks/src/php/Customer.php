<?php
class CustomerMethods 
{ public static function CreateNewCustomer($customerDetails,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Customer/CreateNewCustomer", "customerDetails=" . json_encode($customerDetails) . "", $ApiToken, $ApiServer); 
} 
}
?>