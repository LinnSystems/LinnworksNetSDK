using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class InventoryChannel
	{
		public String Source { get; set; }

		public String SubSource { get; set; }

		public String SourceVersion { get; set; }

		public String SourceType { get; set; }

		public Double Width { get; set; }

		public Int32 ChannelId { get; set; }
	} 
}