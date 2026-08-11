using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateChannelMappingRequest : LinnObject
	{
		public List<ChannelMappingCreateInfo> Mappings { get; set; }
	} 
}