using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigPostalServiceMappingItem : LinnObject
	{
		public Int32 fkChannelId { get; set; }

		public Int32 pkRowId { get; set; }

		public String Tag { get; set; }

		public Guid fkPostalServiceId { get; set; }

		public String PostalServiceName { get; set; }

		public String Site { get; set; }

		public Boolean IsChanged { get; set; }
	} 
}