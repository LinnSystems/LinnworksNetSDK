using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetScrapHistoryResponse
	{
		public GenericPagedResult<ScrapItem> ScrapHistory { get; set; }
	} 
}