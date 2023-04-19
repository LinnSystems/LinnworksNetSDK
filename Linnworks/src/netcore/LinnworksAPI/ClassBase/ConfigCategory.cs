using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigCategory : LinnObject
	{
		public String Id { get; set; }

		public String Name { get; set; }

		public String Path { get; set; }

		public Boolean Default { get; set; }
	} 
}