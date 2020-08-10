using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Specification<ImportGenericFeed,ImportColumn>
	{
		public ImportGenericFeed Feed { get; set; }

		public List<ImportColumn> ColumnMappings { get; set; }

		public List<ExecutionOption> ExecutionOptions { get; set; }
	} 
}