using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Specification<ImportGenericFeed,ImportColumn>
	{
		public ImportGenericFeed Feed;

		public List<ImportColumn> ColumnMappings;

		public List<ExecutionOption> ExecutionOptions;
	} 
}