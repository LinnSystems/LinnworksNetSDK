using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigPaymentMethodMapping
	{
        /// <summary>
        /// Readonly collection of Mapping as mapping should only be modified through the add and remove methods 
        /// </summary>
		public List<ConfigPaymentMethodMappingItem> Mapping;

        /// <summary>
        /// Readonly collection of ChannelServices as mapping should only be modified through the add and remove methods 
        /// </summary>
		public List<ChannelPaymentMethod> ChannelServices;

		public Boolean IsChanged;
	} 
}