using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetScrapCategoriesResponse : LinnObject
	{
		public IEnumerable<ScrapCategory> ScrapCategories { get; set; }
	} 
}