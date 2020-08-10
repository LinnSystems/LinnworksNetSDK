using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OpenOrderBasicInfo
	{
		public Guid rowid { get; set; }

		public String ItemNumber { get; set; }

		public Guid fkOrderID { get; set; }

		public Int32 nOrderId { get; set; }

		public DateTime DispatchBy { get; set; }

		public Int32 Status { get; set; }
	} 
}