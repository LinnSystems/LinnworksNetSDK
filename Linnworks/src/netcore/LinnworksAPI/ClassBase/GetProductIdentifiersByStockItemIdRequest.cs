using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetProductIdentifiersByStockItemIdRequest : LinnObject
	{
		public Guid StockItemId { get; set; }
	} 
}