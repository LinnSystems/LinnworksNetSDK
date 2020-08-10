using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChannelPostalService
	{
		public Int32 fkChannelId { get; set; }

		public Int32 pkRowId { get; set; }

		public String FriendlyName { get; set; }

		public String Tag { get; set; }

		public String Site { get; set; }

		public Boolean IsChanged { get; set; }
	} 
}