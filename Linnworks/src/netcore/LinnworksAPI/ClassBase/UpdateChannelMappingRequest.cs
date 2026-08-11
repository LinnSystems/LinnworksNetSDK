using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateChannelMappingRequest : LinnObject
	{
		public List<ChannelMappingUpdateInfo> Mappings { get; set; }
	} 
}