using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PartialUpdateParameter : LinnObject
	{
		public Guid pkId { get; set; }

		public List<KeyValuePair<String,String>> fieldList { get; set; }
	} 
}