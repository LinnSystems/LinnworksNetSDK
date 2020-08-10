using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Column
	{
		public ColumnNameType ColumnName { get; set; }

		public String DisplayName { get; set; }

		public String ExportName { get; set; }

		public GroupType Group { get; set; }

		public InventoryViewFieldType Field { get; set; }

		public SortDirectionType SortDirection { get; set; }

		public Double Width { get; set; }

		public Boolean IsEditable { get; set; }
	} 
}