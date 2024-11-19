using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PrintingKey : LinnObject
	{
		public Int32? BatchInventoryId { get; set; }

		public Guid Key { get; set; }

		public Guid? LocationId { get; set; }

		public Int32? Quantity { get; set; }
	} 
}