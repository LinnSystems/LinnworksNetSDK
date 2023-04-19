using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class KeyValueGeneric<Guid,Double> : LinnObject
	{
		public Guid Key { get; set; }

		public Double Value { get; set; }
	} 
}