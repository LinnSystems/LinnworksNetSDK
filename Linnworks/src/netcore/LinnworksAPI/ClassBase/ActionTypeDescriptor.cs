using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ActionTypeDescriptor
	{
		public ActionType Value { get; set; }

		public String DisplayName { get; set; }

		public ActionTypeDescriptorProperties[] Properties { get; set; }

		public DisplayType DisplayType { get; set; }

		public FieldType FieldType { get; set; }
	} 
}