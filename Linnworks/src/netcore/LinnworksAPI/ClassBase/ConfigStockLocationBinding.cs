using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.ObjectModel;

namespace LinnworksAPI
{ 
    public class ConfigStockLocationBinding
	{
		public ReadOnlyCollection<ConfigStockLocation> Locations { get; set; }
	} 
}