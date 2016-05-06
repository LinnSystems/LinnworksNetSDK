using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class ConditionItemBasic
{ public Int32 pkConditionItemId;
public Int32 fkConditionId;
public String FieldName;
public EvaluatorType Evaluation;
public List<String> Values;
public String KeyValue;
 
} 
}