using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SetSettingRequest
	{
		public String Value { get; set; }

		public String HashKey { get; set; }

		public Guid? Key { get; set; }

		public Boolean IsPublic { get; set; }
	} 
}