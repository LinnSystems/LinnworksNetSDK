using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.ObjectModel;

namespace LinnworksAPI
{ 
    public class ConfigPostalServiceMapping : LinnObject
	{
		public ReadOnlyCollection<ConfigPostalServiceMappingItem> Mapping { get; set; }

		public ReadOnlyCollection<ChannelPostalService> ChannelServices { get; set; }

		public Boolean IsChanged { get; set; }
	} 
}