using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AmazonBNode : LinnObject
	{
		public String NodeId { get; set; }

		public String NodePath { get; set; }

		public String ItemType { get; set; }

		public String DepartmentName { get; set; }

		public Boolean IsDefault { get; set; }
	} 
}