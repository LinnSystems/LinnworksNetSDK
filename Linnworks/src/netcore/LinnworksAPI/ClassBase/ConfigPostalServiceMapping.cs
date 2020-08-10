using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.ObjectModel;

namespace LinnworksAPI
{ 
    public class ConfigPostalServiceMapping
	{
        /// <summary>
        /// Readonly collection of Mapping as mapping should only be modified through the add and remove methods 
        /// </summary>
		public ReadOnlyCollection<ConfigPostalServiceMappingItem> Mapping { get; set; }

        /// <summary>
        /// Readonly collection of ChannelServices as mapping should only be modified through the add and remove methods 
        /// </summary>
		public ReadOnlyCollection<ChannelPostalService> ChannelServices { get; set; }

		public Boolean IsChanged { get; set; }
	} 
}