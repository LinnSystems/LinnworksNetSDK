using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigChannelLocation : LinnObject
	{
		public Int32 pkChannelLocationId { get; set; }

		public String Identifier { get; set; }

		public String Name { get; set; }

		public String ExternalReference { get; set; }

		public Guid OrderDownloadLocation { get; set; }

		public List<Guid> InventorySyncLocations { get; set; }

		public ConfigChannelLocationTypes Types { get; set; }

		public Boolean Deleted { get; set; }

		public Boolean IsFulfilment { get; set; }

		public Dictionary<String,Object> AdditionalFields { get; set; }
	} 
}