using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.ObjectModel;

namespace LinnworksAPI
{ 
    public class ConfigChannelLocationBinding : LinnObject
	{
		public ReadOnlyCollection<ConfigChannelLocation> Locations { get; set; }
	} 
}