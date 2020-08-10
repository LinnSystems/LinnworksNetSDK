using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemProductIdentifier
	{
		public Int64 PkId { get; set; }

		public Guid StockItemId { get; set; }

		public ProductIdentifierType Type { get; set; }

		public String Site { get; set; }

		public String Value { get; set; }

		public DateTime ModifiedDate { get; set; }

		public String ModifiedUserName { get; set; }
	} 
}