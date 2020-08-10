using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Export base settings 
    /// </summary>
    public class ExportSpecification
	{
        /// <summary>
        /// Export Column Names 
        /// </summary>
		public Boolean ExportColumnNames { get; set; }

        /// <summary>
        /// Type of delimeter used 
        /// </summary>
		public String Delimiter { get; set; }

        /// <summary>
        /// Escapes used (/ or ") 
        /// </summary>
		public String Escape { get; set; }

        /// <summary>
        /// Any custom SQL scripts used 
        /// </summary>
		public String CustomScript { get; set; }

		public ExportGenericFeed Feed { get; set; }

		public List<ExportColumn> ColumnMappings { get; set; }

		public List<ExecutionOption> ExecutionOptions { get; set; }
	} 
}