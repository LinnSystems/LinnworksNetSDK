using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderItemSerialModel : LinnObject
	{
		public Guid OrderItemRowId { get; set; }

		public List<List<SerialModel>> CorrelationSerials { get; set; }
	} 
}