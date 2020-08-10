using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ExportColumn
	{
		public Int32 Order { get; set; }

		public Filters Filters { get; set; }

		public Boolean ExportToFile { get; set; }

        /// <summary>
        /// list of subquery selection fields. Here we specify the predicate for field value for the given row 
        /// </summary>
		public List<SubQueryOutputMappingSelectionField> SubQuerySelection { get; set; }

		public String FileColumn { get; set; }

		public String Column { get; set; }

		public String Expression { get; set; }

		public String DefaultValue { get; set; }

		public Boolean Visible { get; set; }
	} 
}