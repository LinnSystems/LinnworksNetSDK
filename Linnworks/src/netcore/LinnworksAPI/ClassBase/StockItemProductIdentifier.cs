using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemProductIdentifier
	{
		public Int64 PkId;

		public Guid StockItemId;

		public ProductIdentifierType Type;

		public String Value;

		public DateTime ModifiedDate;

		public String ModifiedUserName;
	} 
}