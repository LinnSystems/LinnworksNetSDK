using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigPaymentMethodMapping : LinnObject
	{
		public List<ConfigPaymentMethodMappingItem> Mapping { get; set; }

		public List<ChannelPaymentMethod> ChannelServices { get; set; }

		public Boolean IsChanged { get; set; }
	} 
}