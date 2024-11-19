using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateTemplatesInBulkChannelParameters : LinnObject
	{
		public Int32 ChannelId { get; set; }

		public Guid ConfiguratorId { get; set; }
	} 
}