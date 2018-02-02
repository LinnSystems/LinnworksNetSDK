using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigStockLocation
	{
		public Guid pkStockLocationId;

		public Boolean Deleted;

		public Int32 fkChannelLocationId;
	} 
}