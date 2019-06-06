using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OpenOrderBasicInfo
	{
		public Guid rowid;

		public String ItemNumber;

		public Guid fkOrderID;

		public Int32 nOrderId;

		public DateTime DispatchBy;

		public Int32 Status;
	} 
}