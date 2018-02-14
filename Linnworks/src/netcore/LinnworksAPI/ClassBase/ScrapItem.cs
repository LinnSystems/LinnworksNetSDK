using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ScrapItem
	{
		public Guid Id;

		public Guid StockItemId;

		public String ItemNumber;

		public String ItemTitle;

		public Int32 Quantity;

		public String CategoryName;

		public String ScrapReason;

		public Double TotalCost;

		public String UserName;

		public DateTime CreatedDate;
	} 
}