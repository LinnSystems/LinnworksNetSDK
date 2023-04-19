using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class TestpadValue : LinnObject
	{
		public String FieldName { get; set; }

		public String Key { get; set; }

		public List<String> Values { get; set; }
	} 
}