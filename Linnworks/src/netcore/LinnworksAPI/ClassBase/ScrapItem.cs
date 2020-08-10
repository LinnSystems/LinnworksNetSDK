using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ScrapItem
	{
		public Guid Id { get; set; }

		public Guid StockItemId { get; set; }

		public String ItemNumber { get; set; }

		public String ItemTitle { get; set; }

		public Int32 Quantity { get; set; }

		public String CategoryName { get; set; }

		public String ScrapReason { get; set; }

		public Double TotalCost { get; set; }

		public String UserName { get; set; }

		public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Stock location Id, nullable as historically this filed has not been set and therefore some entries in the database may not have location against the scrap item. 
        /// </summary>
		public Guid? StockLocationId { get; set; }
	} 
}