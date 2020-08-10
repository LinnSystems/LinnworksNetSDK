using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class JobOrder
	{
		public Guid OrderId { get; set; }

		public Int32 nOrderId { get; set; }

		public String CustomerName { get; set; }

		public String EmailAddress { get; set; }
	} 
}