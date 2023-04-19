using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BigCommerceCustomField : LinnObject
	{
		public Int32 Id { get; set; }

		public Int32 BigCommerceId { get; set; }

		public Guid FlexSettingsItemId { get; set; }

		public String Name { get; set; }

		public String Value { get; set; }
	} 
}