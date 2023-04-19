using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateTemplatesRequest : LinnObject
	{
		public ChannelType ChannelType { get; set; }

		public String ChannelName { get; set; }

		public InventorySearchParameters Parameters { get; set; }

		public PaginationParameters PaginationParameters { get; set; }

		public Int32 ConfiguratorId { get; set; }
	} 
}