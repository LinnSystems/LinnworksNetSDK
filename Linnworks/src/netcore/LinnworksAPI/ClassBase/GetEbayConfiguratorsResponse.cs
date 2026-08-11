using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetEbayConfiguratorsResponse : LinnObject
	{
        /// <summary>
        /// Contains the list of EBAY configurators, flattened grouped by subsource 
        /// </summary>
		public List<EbaySourceConfigurator> SourceConfiguratorData { get; set; }
	} 
}