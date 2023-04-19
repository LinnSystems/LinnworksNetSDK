using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddScrapCategoriesRequest : LinnObject
	{
		public List<String> CategoryNames { get; set; }
	} 
}