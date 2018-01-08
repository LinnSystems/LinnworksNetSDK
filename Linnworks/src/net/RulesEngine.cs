using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{
	public static class RulesEngineMethods 
	{ 
		private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ"};
 		public static List<EvaluatorDescriptor> GetEvaluatorTypes(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<EvaluatorDescriptor>>(Factory.GetResponse("RulesEngine/GetEvaluatorTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<FieldDescriptor> GetEvaluationFields(RuleSetType type,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<FieldDescriptor>>(Factory.GetResponse("RulesEngine/GetEvaluationFields", "type=" + type + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<String> GetOptions(String fieldName,RuleSetType type,String key,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("RulesEngine/GetOptions", "fieldName=" + fieldName + "&type=" + type + "&key=" + key + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<MultiOptionResponse> GetMultiOptions(RuleSetType type,List<FieldKeys> fieldKeys,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<MultiOptionResponse>>(Factory.GetResponse("RulesEngine/GetMultiOptions", "type=" + type + "&fieldKeys=" + Newtonsoft.Json.JsonConvert.SerializeObject(fieldKeys, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<String> GetKeyOptions(RuleSetType type,String fieldName,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("RulesEngine/GetKeyOptions", "type=" + type + "&fieldName=" + fieldName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<MultiKeyOptionResponse> GetMultiKeyOptions(RuleSetType type,List<String> fieldNames,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<MultiKeyOptionResponse>>(Factory.GetResponse("RulesEngine/GetMultiKeyOptions", "type=" + type + "&fieldNames=" + Newtonsoft.Json.JsonConvert.SerializeObject(fieldNames, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<RuleHeaderBasic> GetRules(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<RuleHeaderBasic>>(Factory.GetResponse("RulesEngine/GetRules", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<RuleHeaderBasic> GetRulesByType(RuleSetType type,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<RuleHeaderBasic>>(Factory.GetResponse("RulesEngine/GetRulesByType", "type=" + type + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<RuleConditionHeader> GetRuleConditionNodes(Int32 pkRuleId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<RuleConditionHeader>>(Factory.GetResponse("RulesEngine/GetRuleConditionNodes", "pkRuleId=" + pkRuleId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static ConditionHeaderBasic GetConditionWeb(Int32 pkConditionId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ConditionHeaderBasic>(Factory.GetResponse("RulesEngine/GetConditionWeb", "pkConditionId=" + pkConditionId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<ActionTypeDescriptor> GetActionTypes(RuleSetType type,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ActionTypeDescriptor>>(Factory.GetResponse("RulesEngine/GetActionTypes", "type=" + type + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static RuleConditionHeader CreateNewCondition(ConditionHeaderBasic header,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<RuleConditionHeader>(Factory.GetResponse("RulesEngine/CreateNewCondition", "header=" + Newtonsoft.Json.JsonConvert.SerializeObject(header, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void SaveConditionChanges(ConditionHeaderBasic conditionHeader,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("RulesEngine/SaveConditionChanges", "conditionHeader=" + Newtonsoft.Json.JsonConvert.SerializeObject(conditionHeader, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static Boolean CheckConditionNameExists(Int32 fkRuleId,Int32? fkConditionId,Int32? excludeConditionId,String conditionName,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(Factory.GetResponse("RulesEngine/CheckConditionNameExists", "fkRuleId=" + fkRuleId + "&fkConditionId=" + Newtonsoft.Json.JsonConvert.SerializeObject(fkConditionId, serializerSettings) + "&excludeConditionId=" + Newtonsoft.Json.JsonConvert.SerializeObject(excludeConditionId, serializerSettings) + "&conditionName=" + conditionName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Dictionary<String,List<ActionOption>> GetActionOptions(ActionType type,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String,List<ActionOption>>>(Factory.GetResponse("RulesEngine/GetActionOptions", "type=" + type + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void UpdateAction(ActionWeb action,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("RulesEngine/UpdateAction", "action=" + Newtonsoft.Json.JsonConvert.SerializeObject(action, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static ActionWeb AddAction(ActionWeb action,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ActionWeb>(Factory.GetResponse("RulesEngine/AddAction", "action=" + Newtonsoft.Json.JsonConvert.SerializeObject(action, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void DeleteAction(Int32 pkActionId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("RulesEngine/DeleteAction", "pkActionId=" + pkActionId + "", ApiToken, ApiServer); 
		}

		public static void DeleteCondition(Int32 pkConditionId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("RulesEngine/DeleteCondition", "pkConditionId=" + pkConditionId + "", ApiToken, ApiServer); 
		}

		public static void SwapConditions(Int32 pkConditionId1,Int32 pkConditionId2,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("RulesEngine/SwapConditions", "pkConditionId1=" + pkConditionId1 + "&pkConditionId2=" + pkConditionId2 + "", ApiToken, ApiServer); 
		}

		public static RulesFields GetRequiredFieldsByRuleId(Int32 pkRuleId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<RulesFields>(Factory.GetResponse("RulesEngine/GetRequiredFieldsByRuleId", "pkRuleId=" + pkRuleId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static RulesFields GetRequiredFieldsByType(RuleSetType type,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<RulesFields>(Factory.GetResponse("RulesEngine/GetRequiredFieldsByType", "type=" + type + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static RuleEvaluationResult TestEvaluateRule(List<TestpadValue> testValues,Int32 pkRuleId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<RuleEvaluationResult>(Factory.GetResponse("RulesEngine/TestEvaluateRule", "testValues=" + Newtonsoft.Json.JsonConvert.SerializeObject(testValues, serializerSettings) + "&pkRuleId=" + pkRuleId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<TestpadValue> GetValuesFromExisting(Int32 pkRuleId,Object id,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<TestpadValue>>(Factory.GetResponse("RulesEngine/GetValuesFromExisting", "pkRuleId=" + pkRuleId + "&id=" + Newtonsoft.Json.JsonConvert.SerializeObject(id, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Int32? SetDraftLive(Int32 pkRuleId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Int32?>(Factory.GetResponse("RulesEngine/SetDraftLive", "pkRuleId=" + pkRuleId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Int32 CreateDraftFromExisting(Int32 pkRuleId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Int32>(Factory.GetResponse("RulesEngine/CreateDraftFromExisting", "pkRuleId=" + pkRuleId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static RuleHeaderBasic CreateNewDraftFromExisting(Int32 pkRuleId,String ruleName,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<RuleHeaderBasic>(Factory.GetResponse("RulesEngine/CreateNewDraftFromExisting", "pkRuleId=" + pkRuleId + "&ruleName=" + ruleName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static RuleHeaderBasic CreateNewDraft(String ruleName,RuleSetType type,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<RuleHeaderBasic>(Factory.GetResponse("RulesEngine/CreateNewDraft", "ruleName=" + ruleName + "&type=" + type + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void SetRuleEnabled(Int32 pkRuleId,Boolean enabled,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("RulesEngine/SetRuleEnabled", "pkRuleId=" + pkRuleId + "&enabled=" + enabled + "", ApiToken, ApiServer); 
		}

		public static void SetRuleName(Int32 pkRuleId,String ruleName,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("RulesEngine/SetRuleName", "pkRuleId=" + pkRuleId + "&ruleName=" + ruleName + "", ApiToken, ApiServer); 
		}

		public static void DeleteRuleById(Int32 pkRuleId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("RulesEngine/DeleteRuleById", "pkRuleId=" + pkRuleId + "", ApiToken, ApiServer); 
		}

		public static void SwapRules(Int32 pkRuleId1,Int32 pkRuleId2,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("RulesEngine/SwapRules", "pkRuleId1=" + pkRuleId1 + "&pkRuleId2=" + pkRuleId2 + "", ApiToken, ApiServer); 
		}

		public static void SetConditionEnabled(Int32 pkConditionId,Boolean enabled,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("RulesEngine/SetConditionEnabled", "pkConditionId=" + pkConditionId + "&enabled=" + enabled + "", ApiToken, ApiServer); 
		}

		public static RuleConditionHeader CopyCondition(Int32 pkRuleId,Int32? targetParentConditionId,Int32 pkConditionId,Boolean includeChildren,Boolean includeActions,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<RuleConditionHeader>(Factory.GetResponse("RulesEngine/CopyCondition", "pkRuleId=" + pkRuleId + "&targetParentConditionId=" + Newtonsoft.Json.JsonConvert.SerializeObject(targetParentConditionId, serializerSettings) + "&pkConditionId=" + pkConditionId + "&includeChildren=" + includeChildren + "&includeActions=" + includeActions + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static RuleAction CopyAction(Int32 pkRuleId,Int32 targetParentConditionId,Int32 pkActionId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<RuleAction>(Factory.GetResponse("RulesEngine/CopyAction", "pkRuleId=" + pkRuleId + "&targetParentConditionId=" + targetParentConditionId + "&pkActionId=" + pkActionId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		} 
	}
}