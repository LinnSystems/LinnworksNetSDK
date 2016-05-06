using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class ExportColumn
{ public Int32 Order;
public Filters Filters;
public List<SubQueryOutputMappingSelectionField> SubQuerySelection;
public String FileColumn;
public String Column;
public String Expression;
public String DefaultValue;
public Boolean Visible;
 
} 
}