using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateBatchDatesRequest : LinnObject
	{
		public List<BatchDatesUpdateItem> Items { get; set; }
	} 
}