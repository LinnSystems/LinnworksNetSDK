<?php
class RulesEngineMethods 
{ public static function AddAction($action,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/AddAction", "action=" . json_encode($action) . "", $ApiToken, $ApiServer)); 
}

public static function CheckConditionNameExists($fkRuleId,$fkConditionId,$excludeConditionId,$conditionName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/CheckConditionNameExists", "fkRuleId=" . $fkRuleId . "&fkConditionId=" . json_encode($fkConditionId) . "&excludeConditionId=" . json_encode($excludeConditionId) . "&conditionName=" . $conditionName . "", $ApiToken, $ApiServer)); 
}

public static function CopyAction($pkRuleId,$targetParentConditionId,$pkActionId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/CopyAction", "pkRuleId=" . $pkRuleId . "&targetParentConditionId=" . $targetParentConditionId . "&pkActionId=" . $pkActionId . "", $ApiToken, $ApiServer)); 
}

public static function CopyCondition($pkRuleId,$targetParentConditionId,$pkConditionId,$includeChildren,$includeActions,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/CopyCondition", "pkRuleId=" . $pkRuleId . "&targetParentConditionId=" . json_encode($targetParentConditionId) . "&pkConditionId=" . $pkConditionId . "&includeChildren=" . $includeChildren . "&includeActions=" . $includeActions . "", $ApiToken, $ApiServer)); 
}

public static function CreateDraftFromExisting($pkRuleId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/CreateDraftFromExisting", "pkRuleId=" . $pkRuleId . "", $ApiToken, $ApiServer)); 
}

public static function CreateNewCondition($header,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/CreateNewCondition", "header=" . json_encode($header) . "", $ApiToken, $ApiServer)); 
}

public static function CreateNewDraft($ruleName,$type,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/CreateNewDraft", "ruleName=" . $ruleName . "&type=" . $type . "", $ApiToken, $ApiServer)); 
}

public static function CreateNewDraftFromExisting($pkRuleId,$ruleName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/CreateNewDraftFromExisting", "pkRuleId=" . $pkRuleId . "&ruleName=" . $ruleName . "", $ApiToken, $ApiServer)); 
}

public static function DeleteAction($pkActionId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("RulesEngine/DeleteAction", "pkActionId=" . $pkActionId . "", $ApiToken, $ApiServer); 
}

public static function DeleteCondition($pkConditionId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("RulesEngine/DeleteCondition", "pkConditionId=" . $pkConditionId . "", $ApiToken, $ApiServer); 
}

public static function DeleteRuleById($pkRuleId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("RulesEngine/DeleteRuleById", "pkRuleId=" . $pkRuleId . "", $ApiToken, $ApiServer); 
}

public static function GetActionOptions($type,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/GetActionOptions", "type=" . $type . "", $ApiToken, $ApiServer)); 
}

public static function GetActionTypes($type,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/GetActionTypes", "type=" . $type . "", $ApiToken, $ApiServer)); 
}

public static function GetConditionWeb($pkConditionId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/GetConditionWeb", "pkConditionId=" . $pkConditionId . "", $ApiToken, $ApiServer)); 
}

public static function GetEvaluationFields($type,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/GetEvaluationFields", "type=" . $type . "", $ApiToken, $ApiServer)); 
}

public static function GetEvaluatorTypes($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/GetEvaluatorTypes", "", $ApiToken, $ApiServer)); 
}

public static function GetKeyOptions($type,$fieldName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/GetKeyOptions", "type=" . $type . "&fieldName=" . $fieldName . "", $ApiToken, $ApiServer)); 
}

public static function GetMultiKeyOptions($type,$fieldNames,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/GetMultiKeyOptions", "type=" . $type . "&fieldNames=" . json_encode($fieldNames) . "", $ApiToken, $ApiServer)); 
}

public static function GetMultiOptions($type,$fieldKeys,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/GetMultiOptions", "type=" . $type . "&fieldKeys=" . json_encode($fieldKeys) . "", $ApiToken, $ApiServer)); 
}

public static function GetOptions($fieldName,$type,$key,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/GetOptions", "fieldName=" . $fieldName . "&type=" . $type . "&key=" . $key . "", $ApiToken, $ApiServer)); 
}

public static function GetRequiredFieldsByRuleId($pkRuleId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/GetRequiredFieldsByRuleId", "pkRuleId=" . $pkRuleId . "", $ApiToken, $ApiServer)); 
}

public static function GetRequiredFieldsByType($type,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/GetRequiredFieldsByType", "type=" . $type . "", $ApiToken, $ApiServer)); 
}

public static function GetRuleConditionNodes($pkRuleId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/GetRuleConditionNodes", "pkRuleId=" . $pkRuleId . "", $ApiToken, $ApiServer)); 
}

public static function GetRules($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/GetRules", "", $ApiToken, $ApiServer)); 
}

public static function GetRulesByType($type,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/GetRulesByType", "type=" . $type . "", $ApiToken, $ApiServer)); 
}

public static function GetValuesFromExisting($pkRuleId,$id,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/GetValuesFromExisting", "pkRuleId=" . $pkRuleId . "&id=" . json_encode($id) . "", $ApiToken, $ApiServer)); 
}

public static function SaveConditionChanges($conditionHeader,$ApiToken, $ApiServer)
{
 Factory::GetResponse("RulesEngine/SaveConditionChanges", "conditionHeader=" . json_encode($conditionHeader) . "", $ApiToken, $ApiServer); 
}

public static function SetConditionEnabled($pkConditionId,$enabled,$ApiToken, $ApiServer)
{
 Factory::GetResponse("RulesEngine/SetConditionEnabled", "pkConditionId=" . $pkConditionId . "&enabled=" . $enabled . "", $ApiToken, $ApiServer); 
}

public static function SetDraftLive($pkRuleId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/SetDraftLive", "pkRuleId=" . $pkRuleId . "", $ApiToken, $ApiServer)); 
}

public static function SetRuleEnabled($pkRuleId,$enabled,$ApiToken, $ApiServer)
{
 Factory::GetResponse("RulesEngine/SetRuleEnabled", "pkRuleId=" . $pkRuleId . "&enabled=" . $enabled . "", $ApiToken, $ApiServer); 
}

public static function SetRuleName($pkRuleId,$ruleName,$ApiToken, $ApiServer)
{
 Factory::GetResponse("RulesEngine/SetRuleName", "pkRuleId=" . $pkRuleId . "&ruleName=" . $ruleName . "", $ApiToken, $ApiServer); 
}

public static function SwapConditions($pkConditionId1,$pkConditionId2,$ApiToken, $ApiServer)
{
 Factory::GetResponse("RulesEngine/SwapConditions", "pkConditionId1=" . $pkConditionId1 . "&pkConditionId2=" . $pkConditionId2 . "", $ApiToken, $ApiServer); 
}

public static function SwapRules($pkRuleId1,$pkRuleId2,$ApiToken, $ApiServer)
{
 Factory::GetResponse("RulesEngine/SwapRules", "pkRuleId1=" . $pkRuleId1 . "&pkRuleId2=" . $pkRuleId2 . "", $ApiToken, $ApiServer); 
}

public static function TestEvaluateRule($testValues,$pkRuleId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("RulesEngine/TestEvaluateRule", "testValues=" . json_encode($testValues) . "&pkRuleId=" . $pkRuleId . "", $ApiToken, $ApiServer)); 
}

public static function UpdateAction($action,$ApiToken, $ApiServer)
{
 Factory::GetResponse("RulesEngine/UpdateAction", "action=" . json_encode($action) . "", $ApiToken, $ApiServer); 
} 
}
?>