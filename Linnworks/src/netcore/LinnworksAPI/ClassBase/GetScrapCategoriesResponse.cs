using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetScrapCategoriesResponse
	{
		public IEnumerable<ScrapCategory> ScrapCategories { get; set; }
	} 
}