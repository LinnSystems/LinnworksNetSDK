using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigPostalServiceMappingItem
	{
		public Int32 fkChannelId;

		public Int32 pkRowId;

		public String Tag;

		public Guid fkPostalServiceId;

		public String PostalServiceName;

		public String Site;

		public Boolean IsChanged;
	} 
}