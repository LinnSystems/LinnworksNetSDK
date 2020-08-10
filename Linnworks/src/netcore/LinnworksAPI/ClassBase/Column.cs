using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Column
	{
		public ColumnNameType ColumnName;

		public String DisplayName;

		public String ExportName;

		public GroupType Group;

		public InventoryViewFieldType Field;

		public SortDirectionType SortDirection;

		public Double Width;

		public Boolean IsEditable;
	} 
}