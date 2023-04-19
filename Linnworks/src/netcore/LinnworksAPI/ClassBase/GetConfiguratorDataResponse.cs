using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetConfiguratorDataResponse : LinnObject
	{
		public Dictionary<String,Object> Data { get; set; }
	} 
}