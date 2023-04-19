using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class LinnLiveEbayAttribute : LinnObject
	{
		public String AttrName { get; set; }

		public String Value { get; set; }

		public String ErrorMessage { get; set; }

		public String CurrentProductValue { get; set; }

		public Boolean IsUserDefined { get; set; }

		public Boolean IsRequired { get; set; }

		public List<String> ValidValues { get; set; }
	} 
}