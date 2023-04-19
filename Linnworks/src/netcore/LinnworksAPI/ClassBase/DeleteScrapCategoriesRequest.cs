using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteScrapCategoriesRequest : LinnObject
	{
		public IEnumerable<Int32> CategoryIds { get; set; }
	} 
}