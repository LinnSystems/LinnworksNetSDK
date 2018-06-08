using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DataPurgeFoundEntryResponse
	{
		public String FullName;

		public String CustomerDetails;

		public List<Int32> OrderIds;

		public List<Guid> pkOrderIds;
	} 
}