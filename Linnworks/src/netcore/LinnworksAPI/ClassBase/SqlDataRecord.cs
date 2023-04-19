using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SqlDataRecord : LinnObject
	{
		public Int32 FieldCount { get; set; }

		public Object Item { get; set; }
	} 
}