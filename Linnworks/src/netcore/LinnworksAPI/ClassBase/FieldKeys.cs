using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class FieldKeys : LinnObject
	{
		public String FieldName { get; set; }

		public List<String> Keys { get; set; }
	} 
}