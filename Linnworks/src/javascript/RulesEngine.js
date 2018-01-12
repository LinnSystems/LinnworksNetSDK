var RulesEngine =
{
	// http://apidoc.linnworks.net/#/RulesEngine-AddAction
	AddAction: function(action,token, server)
	{
		return Factory.GetResponse("RulesEngine/AddAction", token, server, "action=" + JSON.stringify(action) +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-CheckConditionNameExists
	CheckConditionNameExists: function(fkRuleId,fkConditionId,excludeConditionId,conditionName,token, server)
	{
		return Factory.GetResponse("RulesEngine/CheckConditionNameExists", token, server, "fkRuleId=" + fkRuleId + "&fkConditionId=" + JSON.stringify(fkConditionId) + "&excludeConditionId=" + JSON.stringify(excludeConditionId) + "&conditionName=" + conditionName +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-CopyAction
	CopyAction: function(pkRuleId,targetParentConditionId,pkActionId,token, server)
	{
		return Factory.GetResponse("RulesEngine/CopyAction", token, server, "pkRuleId=" + pkRuleId + "&targetParentConditionId=" + targetParentConditionId + "&pkActionId=" + pkActionId +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-CopyCondition
	CopyCondition: function(pkRuleId,targetParentConditionId,pkConditionId,includeChildren,includeActions,token, server)
	{
		return Factory.GetResponse("RulesEngine/CopyCondition", token, server, "pkRuleId=" + pkRuleId + "&targetParentConditionId=" + JSON.stringify(targetParentConditionId) + "&pkConditionId=" + pkConditionId + "&includeChildren=" + includeChildren + "&includeActions=" + includeActions +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-CreateDraftFromExisting
	CreateDraftFromExisting: function(pkRuleId,token, server)
	{
		return Factory.GetResponse("RulesEngine/CreateDraftFromExisting", token, server, "pkRuleId=" + pkRuleId +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-CreateNewCondition
	CreateNewCondition: function(header,token, server)
	{
		return Factory.GetResponse("RulesEngine/CreateNewCondition", token, server, "header=" + JSON.stringify(header) +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-CreateNewDraft
	CreateNewDraft: function(ruleName,type,token, server)
	{
		return Factory.GetResponse("RulesEngine/CreateNewDraft", token, server, "ruleName=" + ruleName + "&type=" + type +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-CreateNewDraftFromExisting
	CreateNewDraftFromExisting: function(pkRuleId,ruleName,token, server)
	{
		return Factory.GetResponse("RulesEngine/CreateNewDraftFromExisting", token, server, "pkRuleId=" + pkRuleId + "&ruleName=" + ruleName +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-DeleteAction
	DeleteAction: function(pkActionId,token, server)
	{
		return Factory.GetResponse("RulesEngine/DeleteAction", token, server, "pkActionId=" + pkActionId +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-DeleteCondition
	DeleteCondition: function(pkConditionId,token, server)
	{
		return Factory.GetResponse("RulesEngine/DeleteCondition", token, server, "pkConditionId=" + pkConditionId +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-DeleteRuleById
	DeleteRuleById: function(pkRuleId,token, server)
	{
		return Factory.GetResponse("RulesEngine/DeleteRuleById", token, server, "pkRuleId=" + pkRuleId +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-GetActionOptions
	GetActionOptions: function(type,token, server)
	{
		return Factory.GetResponse("RulesEngine/GetActionOptions", token, server, "type=" + type +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-GetActionTypes
	GetActionTypes: function(type,token, server)
	{
		return Factory.GetResponse("RulesEngine/GetActionTypes", token, server, "type=" + type +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-GetConditionWeb
	GetConditionWeb: function(pkConditionId,token, server)
	{
		return Factory.GetResponse("RulesEngine/GetConditionWeb", token, server, "pkConditionId=" + pkConditionId +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-GetEvaluationFields
	GetEvaluationFields: function(type,token, server)
	{
		return Factory.GetResponse("RulesEngine/GetEvaluationFields", token, server, "type=" + type +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-GetEvaluatorTypes
	GetEvaluatorTypes: function(token, server)
	{
		return Factory.GetResponse("RulesEngine/GetEvaluatorTypes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-GetKeyOptions
	GetKeyOptions: function(type,fieldName,token, server)
	{
		return Factory.GetResponse("RulesEngine/GetKeyOptions", token, server, "type=" + type + "&fieldName=" + fieldName +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-GetMultiKeyOptions
	GetMultiKeyOptions: function(type,fieldNames,token, server)
	{
		return Factory.GetResponse("RulesEngine/GetMultiKeyOptions", token, server, "type=" + type + "&fieldNames=" + JSON.stringify(fieldNames) +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-GetMultiOptions
	GetMultiOptions: function(type,fieldKeys,token, server)
	{
		return Factory.GetResponse("RulesEngine/GetMultiOptions", token, server, "type=" + type + "&fieldKeys=" + JSON.stringify(fieldKeys) +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-GetOptions
	GetOptions: function(fieldName,type,key,token, server)
	{
		return Factory.GetResponse("RulesEngine/GetOptions", token, server, "fieldName=" + fieldName + "&type=" + type + "&key=" + key +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-GetRequiredFieldsByRuleId
	GetRequiredFieldsByRuleId: function(pkRuleId,token, server)
	{
		return Factory.GetResponse("RulesEngine/GetRequiredFieldsByRuleId", token, server, "pkRuleId=" + pkRuleId +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-GetRequiredFieldsByType
	GetRequiredFieldsByType: function(type,token, server)
	{
		return Factory.GetResponse("RulesEngine/GetRequiredFieldsByType", token, server, "type=" + type +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-GetRuleConditionNodes
	GetRuleConditionNodes: function(pkRuleId,token, server)
	{
		return Factory.GetResponse("RulesEngine/GetRuleConditionNodes", token, server, "pkRuleId=" + pkRuleId +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-GetRules
	GetRules: function(token, server)
	{
		return Factory.GetResponse("RulesEngine/GetRules", token, server, "");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-GetRulesByType
	GetRulesByType: function(type,token, server)
	{
		return Factory.GetResponse("RulesEngine/GetRulesByType", token, server, "type=" + type +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-GetValuesFromExisting
	GetValuesFromExisting: function(pkRuleId,id,token, server)
	{
		return Factory.GetResponse("RulesEngine/GetValuesFromExisting", token, server, "pkRuleId=" + pkRuleId + "&id=" + JSON.stringify(id) +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-SaveConditionChanges
	SaveConditionChanges: function(conditionHeader,token, server)
	{
		return Factory.GetResponse("RulesEngine/SaveConditionChanges", token, server, "conditionHeader=" + JSON.stringify(conditionHeader) +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-SetConditionEnabled
	SetConditionEnabled: function(pkConditionId,enabled,token, server)
	{
		return Factory.GetResponse("RulesEngine/SetConditionEnabled", token, server, "pkConditionId=" + pkConditionId + "&enabled=" + enabled +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-SetDraftLive
	SetDraftLive: function(pkRuleId,token, server)
	{
		return Factory.GetResponse("RulesEngine/SetDraftLive", token, server, "pkRuleId=" + pkRuleId +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-SetRuleEnabled
	SetRuleEnabled: function(pkRuleId,enabled,token, server)
	{
		return Factory.GetResponse("RulesEngine/SetRuleEnabled", token, server, "pkRuleId=" + pkRuleId + "&enabled=" + enabled +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-SetRuleName
	SetRuleName: function(pkRuleId,ruleName,token, server)
	{
		return Factory.GetResponse("RulesEngine/SetRuleName", token, server, "pkRuleId=" + pkRuleId + "&ruleName=" + ruleName +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-SwapConditions
	SwapConditions: function(pkConditionId1,pkConditionId2,token, server)
	{
		return Factory.GetResponse("RulesEngine/SwapConditions", token, server, "pkConditionId1=" + pkConditionId1 + "&pkConditionId2=" + pkConditionId2 +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-SwapRules
	SwapRules: function(pkRuleId1,pkRuleId2,token, server)
	{
		return Factory.GetResponse("RulesEngine/SwapRules", token, server, "pkRuleId1=" + pkRuleId1 + "&pkRuleId2=" + pkRuleId2 +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-TestEvaluateRule
	TestEvaluateRule: function(testValues,pkRuleId,token, server)
	{
		return Factory.GetResponse("RulesEngine/TestEvaluateRule", token, server, "testValues=" + JSON.stringify(testValues) + "&pkRuleId=" + pkRuleId +"");
	},
	// http://apidoc.linnworks.net/#/RulesEngine-UpdateAction
	UpdateAction: function(action,token, server)
	{
		return Factory.GetResponse("RulesEngine/UpdateAction", token, server, "action=" + JSON.stringify(action) +"");
	},
};
