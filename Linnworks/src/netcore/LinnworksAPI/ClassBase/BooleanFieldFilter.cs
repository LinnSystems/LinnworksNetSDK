using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BooleanFieldFilter : LinnObject
	{
		public Boolean Value { get; set; }

		public FieldCode FieldCode { get; set; }
	} 
}