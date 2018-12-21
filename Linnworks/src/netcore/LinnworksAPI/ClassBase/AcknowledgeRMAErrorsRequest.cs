using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AcknowledgeRMAErrorsRequest
	{
		public Int32 RMAHeaderId;

		public List<Int32> RMARowIds;
	} 
}