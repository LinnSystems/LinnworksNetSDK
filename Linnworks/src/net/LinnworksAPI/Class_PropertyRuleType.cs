using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public enum PropertyRuleType
{ GreaterThan,
GreaterThanOrZero,
LessThan,
NotEmpty,
NotEmptyOrDisabled,
Percent,
PositiveNumber,
Regexp,
Enabled,
Disabled,
DisabledSimple,
Action,
IsFilledOnce,
IsReadOnlyPassword,
ListAtLeastOneSelected,
ListAtLeastOneOf,
Hidden,
 
} 
}