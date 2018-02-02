using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigPaymentMethodMapping
	{
		public List<ConfigPaymentMethodMappingItem> Mapping;

		public List<ChannelPaymentMethod> ChannelServices;

		public Boolean IsChanged;
	} 
}