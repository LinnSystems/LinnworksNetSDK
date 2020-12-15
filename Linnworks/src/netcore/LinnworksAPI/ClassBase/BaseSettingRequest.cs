using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BaseSettingRequest
	{
        /// <summary>
        /// The key to search for within the given storage 
        /// </summary>
		public String HashKey { get; set; }

		public Guid? Key { get; set; }

		public Boolean IsPublic { get; set; }
	} 
}