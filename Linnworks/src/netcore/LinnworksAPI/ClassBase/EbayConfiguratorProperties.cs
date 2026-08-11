using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EbayConfiguratorProperties : LinnObject
	{
		public String ConfiguratorName { get; set; }

		public Guid ConfiguratorId { get; set; }
	} 
}