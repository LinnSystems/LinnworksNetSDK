using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class EbaySourceConfigurator : LinnObject
	{
		public String SourceName { get; set; }

		public List<EbaySubsourceConfigurator> SubsourceConfigurators { get; set; }
	} 
}