using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class KeyList : LinnObject
	{
		public String Key { get; set; }

		public List<String> Values { get; set; }
	} 
}