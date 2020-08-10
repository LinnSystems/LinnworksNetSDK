using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigStockLocation
	{
		public Guid pkStockLocationId { get; set; }

		public Boolean Deleted { get; set; }

		public Int32 fkChannelLocationId { get; set; }
	} 
}