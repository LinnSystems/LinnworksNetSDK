using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockLocation : LinnObject
	{
		public String Address1 { get; set; }

		public String Address2 { get; set; }

		public String City { get; set; }

		public String County { get; set; }

		public String Country { get; set; }

		public String ZipCode { get; set; }

		public Boolean IsNotTrackable { get; set; }

		public String LocationTag { get; set; }

		public Boolean CountInOrderUntilAcknowledgement { get; set; }

		public Boolean FulfilmentCenterDeductStockWhenProcessed { get; set; }

		public Boolean IsWarehouseManaged { get; set; }

		public Guid StockLocationId { get; set; }

		public String LocationName { get; set; }

		public Boolean IsFulfillmentCenter { get; set; }

		public Int32 StockLocationIntId { get; set; }
	} 
}