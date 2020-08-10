using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteScrapCategoriesRequest
	{
		public IEnumerable<Int32> CategoryIds { get; set; }
	} 
}