using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GroupCondition : LinnObject
	{
		public String Where { get; set; }

		public String Inner { get; set; }

		public String Sort { get; set; }
	} 
}