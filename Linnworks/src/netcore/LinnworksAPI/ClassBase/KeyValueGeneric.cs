using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class KeyValueGeneric<KeyType,ValueType> : LinnObject
	{
		public KeyType Key { get; set; }

		public ValueType Value { get; set; }
	} 
}