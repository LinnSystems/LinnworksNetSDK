using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetAvailableChannelsResponse : LinnObject
	{
		public List<ServiceInformation> Channels { get; set; }
	} 
}