using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ExportSpecification : LinnObject
	{
		public Boolean ExportColumnNames { get; set; }

		public String Delimiter { get; set; }

		public String Escape { get; set; }

		public String CustomScript { get; set; }

		public String ExportTimeZone { get; set; }

		public ExportGenericFeed Feed { get; set; }

		public List<ExportColumn> ColumnMappings { get; set; }

		public List<ExecutionOption> ExecutionOptions { get; set; }
	} 
}