using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddScrapCategoriesResponse : LinnObject
	{
		public IEnumerable<ScrapCategory> ScrapCategories { get; set; }
	} 
}