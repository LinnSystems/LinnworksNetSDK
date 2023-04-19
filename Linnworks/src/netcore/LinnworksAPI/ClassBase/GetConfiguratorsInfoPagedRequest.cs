using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetConfiguratorsInfoPagedRequest : LinnObject
	{
		public ChannelType ChannelType { get; set; }

		public String ChannelName { get; set; }

		public PaginationParameters PaginationParameters { get; set; }

		public Boolean IsByConfiguratorIds { get; set; }

		public List<Int32> ConfiguratorIds { get; set; }

		public List<Tuple<Int32,Int32>> SelectedRegions { get; set; }

		public Guid Token { get; set; }
	} 
}