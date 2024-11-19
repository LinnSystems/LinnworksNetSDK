using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateBatchDatesResponse : LinnObject
	{
		public IEnumerable<BatchDatesUpdateItemResult> Items { get; set; }
	} 
}