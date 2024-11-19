using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateTemplatesInBulkParameters : LinnObject
	{
		public Guid LocationId { get; set; }

		public IReadOnlyCollection<CreateTemplatesInBulkChannelParameters> ChannelsConfigurators { get; set; }
	} 
}