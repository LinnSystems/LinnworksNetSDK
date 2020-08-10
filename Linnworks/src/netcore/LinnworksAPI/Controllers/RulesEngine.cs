using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class RulesEngineController : BaseController, IRulesEngineController
    {
        public RulesEngineController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Use this call to add a new action to a condition node. 
        /// </summary>
        /// <param name="action">An object describing the action to add.</param>
        /// <returns>The action object, complete with action id.</returns>
        public ActionWeb AddAction(ActionWeb action)
		{
			var response = GetResponse("RulesEngine/AddAction", "action=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(action)) + "");
            return JsonFormatter.ConvertFromJson<ActionWeb>(response);
		}

		/// <summary>
        /// Use this call to check to see if a condition name already exists at a specific level. 
        /// </summary>
        /// <param name="fkRuleId">The rule id.</param>
        /// <param name="fkConditionId">Must be specified if checking that a condition name exists under a sub-condition. If checking rule-level conditions, do not specify.</param>
        /// <param name="excludeConditionId">If the check is for renaming a condition, specify the condition id here to exclude it from the results.</param>
        /// <param name="conditionName">The name to check.</param>
        /// <returns>True if it exists, False if it does not.</returns>
        public Boolean CheckConditionNameExists(Int32 fkRuleId,Int32? fkConditionId,Int32? excludeConditionId,String conditionName)
		{
			var response = GetResponse("RulesEngine/CheckConditionNameExists", "fkRuleId=" + fkRuleId + "&fkConditionId=" + fkConditionId + "&excludeConditionId=" + excludeConditionId + "&conditionName=" + System.Net.WebUtility.UrlEncode(conditionName) + "");
            return JsonFormatter.ConvertFromJson<Boolean>(response);
		}

		/// <summary>
        /// Use this call to copy an action from one condition to another condition. Actions may not be attached to the rule header or condition nodes with subconditions. 
        /// </summary>
        /// <param name="pkRuleId">The rule which the action belongs to.</param>
        /// <param name="targetParentConditionId">The condition to add the action to.</param>
        /// <param name="pkActionId">The id of the action to copy.</param>
        /// <returns>The new action.</returns>
        public RuleAction CopyAction(Int32 pkRuleId,Int32 targetParentConditionId,Int32 pkActionId)
		{
			var response = GetResponse("RulesEngine/CopyAction", "pkRuleId=" + pkRuleId + "&targetParentConditionId=" + targetParentConditionId + "&pkActionId=" + pkActionId + "");
            return JsonFormatter.ConvertFromJson<RuleAction>(response);
		}

		/// <summary>
        /// Use this call to copy a condition, its subconditions and actions. 
        /// </summary>
        /// <param name="pkRuleId">The rule to which the conditions belong.</param>
        /// <param name="targetParentConditionId">The condition to which the copy should be appended as a child.</param>
        /// <param name="pkConditionId">The condition to copy.</param>
        /// <param name="includeChildren">Include subconditions?</param>
        /// <param name="includeActions">Include actions?</param>
        /// <returns>An object describing the newly created nodes and actions.</returns>
        public RuleConditionHeader CopyCondition(Int32 pkRuleId,Int32? targetParentConditionId,Int32 pkConditionId,Boolean includeChildren,Boolean includeActions)
		{
			var response = GetResponse("RulesEngine/CopyCondition", "pkRuleId=" + pkRuleId + "&targetParentConditionId=" + targetParentConditionId + "&pkConditionId=" + pkConditionId + "&includeChildren=" + includeChildren + "&includeActions=" + includeActions + "");
            return JsonFormatter.ConvertFromJson<RuleConditionHeader>(response);
		}

		/// <summary>
        /// Use this call to create a draft copy in order to edit an existing rule. Once set live, this draft will replace the rule it was copied from. 
        /// </summary>
        /// <param name="pkRuleId">The rule id to create a draft of.</param>
        /// <returns>The id of the draft copy.</returns>
        public Int32 CreateDraftFromExisting(Int32 pkRuleId)
		{
			var response = GetResponse("RulesEngine/CreateDraftFromExisting", "pkRuleId=" + pkRuleId + "");
            return JsonFormatter.ConvertFromJson<Int32>(response);
		}

		/// <summary>
        /// Use this call to create a new condition. 
        /// </summary>
        /// <param name="header">An object describing the condition to be added.</param>
        /// <returns>The condition object including pkConditionId.</returns>
        public RuleConditionHeader CreateNewCondition(ConditionHeaderBasic header)
		{
			var response = GetResponse("RulesEngine/CreateNewCondition", "header=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(header)) + "");
            return JsonFormatter.ConvertFromJson<RuleConditionHeader>(response);
		}

		/// <summary>
        /// Use this call to create a new draft rule of a specified type. 
        /// </summary>
        /// <param name="ruleName">The name for the new draft.</param>
        /// <param name="type">The rule type.</param>
        /// <returns>The rule header.</returns>
        public RuleHeaderBasic CreateNewDraft(String ruleName,RuleSetType type)
		{
			var response = GetResponse("RulesEngine/CreateNewDraft", "ruleName=" + System.Net.WebUtility.UrlEncode(ruleName) + "&type=" + type.ToString() + "");
            return JsonFormatter.ConvertFromJson<RuleHeaderBasic>(response);
		}

		/// <summary>
        /// Use this call to create a new draft based on an existing rule. Once set live, this draft will be a unique rule in its own right. 
        /// </summary>
        /// <param name="pkRuleId">The existing rule id.</param>
        /// <param name="ruleName">The name of the new draft.</param>
        /// <returns>The rule header.</returns>
        public RuleHeaderBasic CreateNewDraftFromExisting(Int32 pkRuleId,String ruleName)
		{
			var response = GetResponse("RulesEngine/CreateNewDraftFromExisting", "pkRuleId=" + pkRuleId + "&ruleName=" + System.Net.WebUtility.UrlEncode(ruleName) + "");
            return JsonFormatter.ConvertFromJson<RuleHeaderBasic>(response);
		}

		/// <summary>
        /// Use this call to delete an action from a rule. 
        /// </summary>
        /// <param name="pkActionId">The id of the action to delete</param>
        public void DeleteAction(Int32 pkActionId)
		{
			GetResponse("RulesEngine/DeleteAction", "pkActionId=" + pkActionId + "");
		}

		/// <summary>
        /// Use this call to delete a conditio and its subconditions/actions 
        /// </summary>
        /// <param name="pkConditionId">The condition to delete</param>
        public void DeleteCondition(Int32 pkConditionId)
		{
			GetResponse("RulesEngine/DeleteCondition", "pkConditionId=" + pkConditionId + "");
		}

		/// <summary>
        /// Use this call to permanently delete a rule from the system. 
        /// </summary>
        /// <param name="pkRuleId">The rule id to delete.</param>
        public void DeleteRuleById(Int32 pkRuleId)
		{
			GetResponse("RulesEngine/DeleteRuleById", "pkRuleId=" + pkRuleId + "");
		}

		/// <summary>
        /// Use this call to get a list of valid options for a given action 
        /// </summary>
        /// <param name="type">The action type</param>
        /// <returns>A list of valid options</returns>
        public Dictionary<String,List<ActionOption>> GetActionOptions(ActionType type)
		{
			var response = GetResponse("RulesEngine/GetActionOptions", "type=" + type.ToString() + "");
            return JsonFormatter.ConvertFromJson<Dictionary<String,List<ActionOption>>>(response);
		}

		/// <summary>
        /// Use this call to retrieve a list of valid action types for the rule type 
        /// </summary>
        /// <param name="type">The rule type.</param>
        /// <returns>Valid action types</returns>
        public List<ActionTypeDescriptor> GetActionTypes(RuleSetType type)
		{
			var response = GetResponse("RulesEngine/GetActionTypes", "type=" + type.ToString() + "");
            return JsonFormatter.ConvertFromJson<List<ActionTypeDescriptor>>(response);
		}

		/// <summary>
        /// Use this call to retrieve details about a given condition. 
        /// </summary>
        /// <param name="pkConditionId">The condition id.</param>
        /// <returns>An object describing the condition and its items.</returns>
        public ConditionHeaderBasic GetConditionWeb(Int32 pkConditionId)
		{
			var response = GetResponse("RulesEngine/GetConditionWeb", "pkConditionId=" + pkConditionId + "");
            return JsonFormatter.ConvertFromJson<ConditionHeaderBasic>(response);
		}

		/// <summary>
        /// Use this call to get a list of valid evaluation fields for a given rule type. 
        /// </summary>
        /// <param name="type">The rule type.</param>
        /// <returns>Returns a list of evaluation available fields.</returns>
        public List<FieldDescriptor> GetEvaluationFields(RuleSetType type)
		{
			var response = GetResponse("RulesEngine/GetEvaluationFields", "type=" + type.ToString() + "");
            return JsonFormatter.ConvertFromJson<List<FieldDescriptor>>(response);
		}

		/// <summary>
        /// Use this call to get a list of valid evaluators and the groups which they belong to. 
        /// </summary>
        /// <returns>Returns a list of valid evaluators.</returns>
        public List<EvaluatorDescriptor> GetEvaluatorTypes()
		{
			var response = GetResponse("RulesEngine/GetEvaluatorTypes", "");
            return JsonFormatter.ConvertFromJson<List<EvaluatorDescriptor>>(response);
		}

		/// <summary>
        /// Use this call to get a list of valid keys for a given field. 
        /// </summary>
        /// <param name="type">The rule type</param>
        /// <param name="fieldName">The field name</param>
        /// <returns>Returns a valid list of keys (e.g. for extended properties, a list of existing property names)</returns>
        public List<String> GetKeyOptions(RuleSetType type,String fieldName)
		{
			var response = GetResponse("RulesEngine/GetKeyOptions", "type=" + type.ToString() + "&fieldName=" + System.Net.WebUtility.UrlEncode(fieldName) + "");
            return JsonFormatter.ConvertFromJson<List<String>>(response);
		}

		/// <summary>
        /// Use this call to get a list of valid keys for a set of fields. 
        /// </summary>
        /// <param name="type">The rule type.</param>
        /// <param name="fieldNames">The field names to get the keys for</param>
        /// <returns>A list of keys grouped by field name</returns>
        public List<MultiKeyOptionResponse> GetMultiKeyOptions(RuleSetType type,List<String> fieldNames)
		{
			var response = GetResponse("RulesEngine/GetMultiKeyOptions", "type=" + type.ToString() + "&fieldNames=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(fieldNames)) + "");
            return JsonFormatter.ConvertFromJson<List<MultiKeyOptionResponse>>(response);
		}

		/// <summary>
        /// Use this call to get a list of valid options for a given set of fields (and, if relevant, keys). 
        /// </summary>
        /// <param name="type">The rule type.</param>
        /// <param name="fieldKeys">A list of fields and optionally keys.</param>
        /// <returns>A list of valid options grouped by Field/Key</returns>
        public List<MultiOptionResponse> GetMultiOptions(RuleSetType type,List<FieldKeys> fieldKeys)
		{
			var response = GetResponse("RulesEngine/GetMultiOptions", "type=" + type.ToString() + "&fieldKeys=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(fieldKeys)) + "");
            return JsonFormatter.ConvertFromJson<List<MultiOptionResponse>>(response);
		}

		/// <summary>
        /// Use this call to get a list of valid options for a given field (and, if relevant, key). 
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="type">The rule type.</param>
        /// <param name="key">The key (optional).</param>
        /// <returns>Returns a list of options.</returns>
        public List<String> GetOptions(String fieldName,RuleSetType type,String key)
		{
			var response = GetResponse("RulesEngine/GetOptions", "fieldName=" + System.Net.WebUtility.UrlEncode(fieldName) + "&type=" + type.ToString() + "&key=" + System.Net.WebUtility.UrlEncode(key) + "");
            return JsonFormatter.ConvertFromJson<List<String>>(response);
		}

		/// <summary>
        /// Use this call to get a list of fields and keys used by a given rule. 
        /// </summary>
        /// <param name="pkRuleId">The rule id</param>
        /// <returns>A object containing a list of fields</returns>
        public RulesFields GetRequiredFieldsByRuleId(Int32 pkRuleId)
		{
			var response = GetResponse("RulesEngine/GetRequiredFieldsByRuleId", "pkRuleId=" + pkRuleId + "");
            return JsonFormatter.ConvertFromJson<RulesFields>(response);
		}

		/// <summary>
        /// Use this call to get a list of fields and keys used by a given rule type 
        /// </summary>
        /// <param name="type">The rule type.</param>
        /// <returns>A object containing a list of fields for enabled rules</returns>
        public RulesFields GetRequiredFieldsByType(RuleSetType type)
		{
			var response = GetResponse("RulesEngine/GetRequiredFieldsByType", "type=" + type.ToString() + "");
            return JsonFormatter.ConvertFromJson<RulesFields>(response);
		}

		/// <summary>
        /// Use this call to get information about the nodes belonging to a rule, excluding the condition items. 
        /// </summary>
        /// <param name="pkRuleId">The rule id.</param>
        /// <returns>An object describing the rule hierarchy.</returns>
        public List<RuleConditionHeader> GetRuleConditionNodes(Int32 pkRuleId)
		{
			var response = GetResponse("RulesEngine/GetRuleConditionNodes", "pkRuleId=" + pkRuleId + "");
            return JsonFormatter.ConvertFromJson<List<RuleConditionHeader>>(response);
		}

		/// <summary>
        /// Use this call to retrieve a list of rules 
        /// </summary>
        /// <returns>A list of rules</returns>
        public List<RuleHeaderBasic> GetRules()
		{
			var response = GetResponse("RulesEngine/GetRules", "");
            return JsonFormatter.ConvertFromJson<List<RuleHeaderBasic>>(response);
		}

		/// <summary>
        /// Use this call to retrieve a list of rules of a given type 
        /// </summary>
        /// <param name="type">The rule type.</param>
        /// <returns>A list of rules of the requested type</returns>
        public List<RuleHeaderBasic> GetRulesByType(RuleSetType type)
		{
			var response = GetResponse("RulesEngine/GetRulesByType", "type=" + type.ToString() + "");
            return JsonFormatter.ConvertFromJson<List<RuleHeaderBasic>>(response);
		}

		/// <summary>
        /// Use this call to get test values from an existing object based on the fields used by a given rule. 
        /// </summary>
        /// <param name="pkRuleId">The rule id</param>
        /// <param name="id">The id (rule-type specific, for orders it is the Linnworks Order Id).</param>
        /// <returns>A list of test values based on the existing object.</returns>
        public List<TestpadValue> GetValuesFromExisting(Int32 pkRuleId,Object id)
		{
			var response = GetResponse("RulesEngine/GetValuesFromExisting", "pkRuleId=" + pkRuleId + "&id=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(id)) + "");
            return JsonFormatter.ConvertFromJson<List<TestpadValue>>(response);
		}

		/// <summary>
        /// Use this call to update a conditon and its condition items. 
        /// </summary>
        /// <param name="conditionHeader">The condition object describing the revised condition. pkConditionId and fkRuleId must be unchanged.</param>
        public void SaveConditionChanges(ConditionHeaderBasic conditionHeader)
		{
			GetResponse("RulesEngine/SaveConditionChanges", "conditionHeader=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(conditionHeader)) + "");
		}

		/// <summary>
        /// Use this call to enable or disable a condition. Any subconditions or actions belonging to the condition will not be evaluated or executed if it is disabled. 
        /// </summary>
        /// <param name="pkConditionId">The condition id.</param>
        /// <param name="enabled">True for enabled, False for disabled.</param>
        public void SetConditionEnabled(Int32 pkConditionId,Boolean enabled)
		{
			GetResponse("RulesEngine/SetConditionEnabled", "pkConditionId=" + pkConditionId + "&enabled=" + enabled + "");
		}

		/// <summary>
        /// Use this call to set a draft rule live (if the draft is a copy for editing an existing rule, the existing rule will be deleted and the draft promoted). 
        /// </summary>
        /// <param name="pkRuleId">The id of the draft rule.</param>
        /// <returns>The run order of the now live rule.</returns>
        public Int32? SetDraftLive(Int32 pkRuleId)
		{
			var response = GetResponse("RulesEngine/SetDraftLive", "pkRuleId=" + pkRuleId + "");
            return JsonFormatter.ConvertFromJson<Int32?>(response);
		}

		/// <summary>
        /// Use this call to set the enabled state of a rule 
        /// </summary>
        /// <param name="pkRuleId">The rule id</param>
        /// <param name="enabled">Boolean incidating whether or not the rule is enabled</param>
        public void SetRuleEnabled(Int32 pkRuleId,Boolean enabled)
		{
			GetResponse("RulesEngine/SetRuleEnabled", "pkRuleId=" + pkRuleId + "&enabled=" + enabled + "");
		}

		/// <summary>
        /// Use this call to rename a rule. 
        /// </summary>
        /// <param name="pkRuleId">The rule id</param>
        /// <param name="ruleName">The new name for the rule</param>
        public void SetRuleName(Int32 pkRuleId,String ruleName)
		{
			GetResponse("RulesEngine/SetRuleName", "pkRuleId=" + pkRuleId + "&ruleName=" + System.Net.WebUtility.UrlEncode(ruleName) + "");
		}

		/// <summary>
        /// Use this call to swap the sort order of two conditions belonging to the same parent 
        /// </summary>
        /// <param name="pkConditionId1">The id of the first condition</param>
        /// <param name="pkConditionId2">The id of the second condition</param>
        public void SwapConditions(Int32 pkConditionId1,Int32 pkConditionId2)
		{
			GetResponse("RulesEngine/SwapConditions", "pkConditionId1=" + pkConditionId1 + "&pkConditionId2=" + pkConditionId2 + "");
		}

		/// <summary>
        /// Use this call to change the executing order of the rules by swapping them with each other. 
        /// </summary>
        /// <param name="pkRuleId1">The first rule id</param>
        /// <param name="pkRuleId2">The second rule id</param>
        public void SwapRules(Int32 pkRuleId1,Int32 pkRuleId2)
		{
			GetResponse("RulesEngine/SwapRules", "pkRuleId1=" + pkRuleId1 + "&pkRuleId2=" + pkRuleId2 + "");
		}

		/// <summary>
        /// Use this call to test a rule against a set of test values 
        /// </summary>
        /// <param name="testValues">Test values</param>
        /// <param name="pkRuleId">The rule to test against</param>
        /// <returns>The action id of the matched action or, where possible, the nearest condition id</returns>
        public RuleEvaluationResult TestEvaluateRule(List<TestpadValue> testValues,Int32 pkRuleId)
		{
			var response = GetResponse("RulesEngine/TestEvaluateRule", "testValues=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(testValues)) + "&pkRuleId=" + pkRuleId + "");
            return JsonFormatter.ConvertFromJson<RuleEvaluationResult>(response);
		}

		/// <summary>
        /// Use this call to update an action 
        /// </summary>
        /// <param name="action">The details of the updated action. pkActionId and fkConditionId must be unchanged original.</param>
        public void UpdateAction(ActionWeb action)
		{
			GetResponse("RulesEngine/UpdateAction", "action=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(action)) + "");
		} 
    }
}