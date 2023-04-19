using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SaveConfiguratorDescriptionRequest : LinnObject
	{
		public ChannelType ChannelType { get; set; }

		public String ChannelName { get; set; }

		public String Description { get; set; }

		public List<Int32> ConfiguratorIds { get; set; }
	} 
}