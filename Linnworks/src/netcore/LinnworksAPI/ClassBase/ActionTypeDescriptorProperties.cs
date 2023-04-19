using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ActionTypeDescriptorProperties : LinnObject
	{
		public String DisplayName { get; set; }

		public DisplayType DisplayType { get; set; }

		public FieldType FieldType { get; set; }
	} 
}