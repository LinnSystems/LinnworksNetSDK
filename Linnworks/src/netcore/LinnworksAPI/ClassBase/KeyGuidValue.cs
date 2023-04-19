using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class KeyGuidValue : LinnObject
	{
		public String Key { get; set; }

		public Guid Value { get; set; }
	} 
}