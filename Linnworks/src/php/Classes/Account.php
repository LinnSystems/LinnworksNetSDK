<?php
class AccountMethods 
{ public static function Account_GenerateAnywhereToken($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Account/Account_GenerateAnywhereToken", "", $ApiToken, $ApiServer)); 
}

public static function Account_Type_MultiUser($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Account/Account_Type_MultiUser", "", $ApiToken, $ApiServer)); 
}

public static function Helpers_Country_List($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Account/Helpers_Country_List", "", $ApiToken, $ApiServer)); 
}

public static function Helpers_Vatin_GetCountryVatInfo($country,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Account/Helpers_Vatin_GetCountryVatInfo", "country=" . $country . "", $ApiToken, $ApiServer)); 
}

public static function AccountDetails_Get($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Account/AccountDetails_Get", "", $ApiToken, $ApiServer)); 
}

public static function AccountDetails_ContactDetails_Update($details,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Account/AccountDetails_ContactDetails_Update", "details=" . json_encode($details) . "", $ApiToken, $ApiServer); 
}

public static function AccountDetails_Forum_Login_Create($forumName,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Account/AccountDetails_Forum_Login_Create", "forumName=" . $forumName . "", $ApiToken, $ApiServer); 
}

public static function AccountDetails_Forum_Login_Update($forumName_current,$forumName_new,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Account/AccountDetails_Forum_Login_Update", "forumName_current=" . $forumName_current . "&forumName_new=" . $forumName_new . "", $ApiToken, $ApiServer); 
}

public static function CreateProfile($profileId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Account/CreateProfile", "profileId=" . $profileId . "", $ApiToken, $ApiServer); 
} 
}
?>