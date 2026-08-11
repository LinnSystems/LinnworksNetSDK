using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChannelOrderId : LinnObject
	{
		public String ReferenceId { get; set; }

		public String ExternalReference { get; set; }

		public String SecondaryReference { get; set; }
	} 
}