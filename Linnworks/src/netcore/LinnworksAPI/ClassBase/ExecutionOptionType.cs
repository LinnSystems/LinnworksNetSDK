using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ExecutionOptionType : LinnObject
	{
		public String Type { get; set; }

		public String Key { get; set; }

		public ExecutionOptionType StockLevelBySupplierCode_ZeroWhenNotProvided { get; set; }

		public ExecutionOptionType FulfilmentCenterInventoryImport_OnlyMatchByFulfilmentSku { get; set; }
	} 
}