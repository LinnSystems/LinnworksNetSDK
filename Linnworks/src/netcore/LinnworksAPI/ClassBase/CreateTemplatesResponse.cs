using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateTemplatesResponse : LinnObject
	{
		public DynamicInfo TemplatesInfo { get; set; }

		public List<Int32> AllCreatedIds { get; set; }
	} 
}