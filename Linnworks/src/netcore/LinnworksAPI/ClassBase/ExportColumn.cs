using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ExportColumn
	{
		public Int32 Order;

		public Filters Filters;

		public Boolean ExportToFile;

        /// <summary>
        /// list of subquery selection fields. Here we specify the predicate for field value for the given row 
        /// </summary>
		public List<SubQueryOutputMappingSelectionField> SubQuerySelection;

		public String FileColumn;

		public String Column;

		public String Expression;

		public String DefaultValue;

		public Boolean Visible;
	} 
}