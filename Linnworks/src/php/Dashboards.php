<?php
class Dashboards 
{ public static function ExecuteCustomScriptQuery($script, $ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Dashboards/ExecuteCustomScriptQuery", "script=" . $script, $ApiToken, $ApiServer)); 
}
}
?>