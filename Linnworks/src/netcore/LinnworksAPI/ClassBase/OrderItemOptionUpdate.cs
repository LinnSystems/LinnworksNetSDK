using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderItemOptionUpdate
	{
		public Boolean DeleteEntry { get; set; }

		public Guid pkOptionId { get; set; }

		public String Property { get; set; }

		public String Value { get; set; }
	} 
}