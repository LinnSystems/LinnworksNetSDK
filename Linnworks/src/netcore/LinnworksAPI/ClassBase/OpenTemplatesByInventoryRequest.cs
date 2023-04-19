using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OpenTemplatesByInventoryRequest : LinnObject
	{
		public ChannelType ChannelType { get; set; }

		public String ChannelName { get; set; }

		public InventorySearchParameters Parameters { get; set; }

		public PaginationParameters PaginationParameters { get; set; }

		public Boolean SelectOnlyWithErrors { get; set; }
	} 
}