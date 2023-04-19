using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateScrapCategoriesRequest : LinnObject
	{
		public List<ScrapCategory> Categories { get; set; }
	} 
}