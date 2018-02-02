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
		public Boolean ExportColumnNames;

        /// <summary>
        /// Type of delimeter used 
        /// </summary>
		public String Delimiter;

        /// <summary>
        /// Escapes used (/ or ") 
        /// </summary>
		public String Escape;

        /// <summary>
        /// Any custom SQL scripts used 
        /// </summary>
		public String CustomScript;

		public ExportGenericFeed Feed;

		public List<ExportColumn> ColumnMappings;

		public List<ExecutionOption> ExecutionOptions;
	} 
}