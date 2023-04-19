using System.Collections.Generic;
using System.Text;
using System;
using Newtonsoft.Json.Linq;

namespace LinnworksAPI
{ 
    public class JToken : LinnObject
	{
		public JTokenEqualityComparer EqualityComparer { get; set; }

		public JContainer Parent { get; set; }

		public JToken Root { get; set; }

		public JTokenType Type { get; set; }

		public Boolean HasValues { get; set; }

		public JToken Next { get; set; }

		public JToken Previous { get; set; }

		public String Path { get; set; }

		public JToken Item { get; set; }

		public JToken First { get; set; }

		public JToken Last { get; set; }
	} 
}