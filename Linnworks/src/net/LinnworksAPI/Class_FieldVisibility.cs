using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class FieldVisibility
{ public String Name;
public Boolean Visible;
public Boolean CanFilter;
public Boolean CanSort;
public FieldTypes FieldType;
public FieldCode Code;
public List<FieldVisibility> SubFields;
public String HotButtonIcon;
public String HotButtonKey;
 
} 
}