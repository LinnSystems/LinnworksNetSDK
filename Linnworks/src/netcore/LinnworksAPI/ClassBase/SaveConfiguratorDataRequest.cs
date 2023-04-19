using System.Collections.Generic;
using System.Text;
using System;
using Newtonsoft.Json.Linq;

namespace LinnworksAPI
{ 
    public class SaveConfiguratorDataRequest : LinnObject
	{
		public ChannelType ChannelType { get; set; }

		public String ChannelName { get; set; }

		public String DataKey { get; set; }

		public List<Int32> Ids { get; set; }

        /// <summary>
        /// Here should come the same data, that was returned from GetConfiguratorData request, with only modifications, allowed by appropriate layout. 
        /// </summary>
		public JObject Data { get; set; }

        /// <summary>
        /// Not valid to use 
        /// </summary>
		public Boolean ForceSave { get; set; }
	} 
}