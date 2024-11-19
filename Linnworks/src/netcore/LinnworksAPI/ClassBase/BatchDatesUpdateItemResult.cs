using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BatchDatesUpdateItemResult : LinnObject
	{
		public String[] Errors { get; set; }

		public Boolean HasError { get; set; }

		public Int32 RowIndex { get; set; }

		public String BatchNumber { get; set; }

		public DateTime SellBy { get; set; }

		public DateTime Expiry { get; set; }

		public String SKU { get; set; }
	} 
}