using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EbaySubsourceConfigurator : LinnObject
	{
		public String SubsourceName { get; set; }

		public List<EbayConfiguratorProperties> Configurators { get; set; }
	} 
}