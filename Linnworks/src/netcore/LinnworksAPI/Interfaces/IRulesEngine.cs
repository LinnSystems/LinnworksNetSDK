using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IRulesEngineController
	{
		ActionWeb AddAction(ActionWeb action);
		Boolean CheckConditionNameExists(Int32 fkRuleId,Int32? fkConditionId,Int32? excludeConditionId,String conditionName);
		RuleAction CopyAction(Int32 pkRuleId,Int32 targetParentConditionId,Int32 pkActionId);
		RuleConditionHeader CopyCondition(Int32 pkRuleId,Int32? targetParentConditionId,Int32 pkConditionId,Boolean includeChildren,Boolean includeActions);
		Int32 CreateDraftFromExisting(Int32 pkRuleId);
		RuleConditionHeader CreateNewCondition(ConditionHeaderBasic header);
		RuleHeaderBasic CreateNewDraft(String ruleName,RuleSetType type);
		RuleHeaderBasic CreateNewDraftFromExisting(Int32 pkRuleId,String ruleName);
		void DeleteAction(Int32 pkActionId);
		void DeleteCondition(Int32 pkConditionId);
		void DeleteRuleById(Int32 pkRuleId);
		Dictionary<String,List<ActionOption>> GetActionOptions(ActionType type);
		List<ActionTypeDescriptor> GetActionTypes(RuleSetType type);
		ConditionHeaderBasic GetConditionWeb(Int32 pkConditionId);
		List<FieldDescriptor> GetEvaluationFields(RuleSetType type);
		List<EvaluatorDescriptor> GetEvaluatorTypes();
		List<String> GetKeyOptions(RuleSetType type,String fieldName);
		List<MultiKeyOptionResponse> GetMultiKeyOptions(RuleSetType type,List<String> fieldNames);
		List<MultiOptionResponse> GetMultiOptions(RuleSetType type,List<FieldKeys> fieldKeys);
		List<String> GetOptions(String fieldName,RuleSetType type,String key);
		RulesFields GetRequiredFieldsByRuleId(Int32 pkRuleId);
		RulesFields GetRequiredFieldsByType(RuleSetType type);
		List<RuleConditionHeader> GetRuleConditionNodes(Int32 pkRuleId);
		List<RuleHeaderBasic> GetRules();
		List<RuleHeaderBasic> GetRulesByType(RuleSetType type);
		List<TestpadValue> GetValuesFromExisting(Int32 pkRuleId,Object id);
		void SaveConditionChanges(ConditionHeaderBasic conditionHeader);
		void SetConditionEnabled(Int32 pkConditionId,Boolean enabled);
		Int32? SetDraftLive(Int32 pkRuleId);
		void SetRuleEnabled(Int32 pkRuleId,Boolean enabled);
		void SetRuleName(Int32 pkRuleId,String ruleName);
		void SwapConditions(Int32 pkConditionId1,Int32 pkConditionId2);
		void SwapRules(Int32 pkRuleId1,Int32 pkRuleId2);
		RuleEvaluationResult TestEvaluateRule(List<TestpadValue> testValues,Int32 pkRuleId);
		void UpdateAction(ActionWeb action);
	} 
}