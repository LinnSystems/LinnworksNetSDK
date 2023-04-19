using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateConfiguratorResponse : LinnObject
	{
		public Object CreatedConfiguratorInfo { get; set; }

		public Int32 CreatedConfiguratorId { get; set; }
	} 
}