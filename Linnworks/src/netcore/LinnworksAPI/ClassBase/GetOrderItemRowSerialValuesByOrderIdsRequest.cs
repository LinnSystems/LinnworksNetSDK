using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOrderItemRowSerialValuesByOrderIdsRequest : LinnObject
	{
		public ICollection<Guid> OrderIds { get; set; }
	} 
}