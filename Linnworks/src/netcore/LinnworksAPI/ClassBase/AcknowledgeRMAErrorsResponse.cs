using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AcknowledgeRMAErrorsResponse
	{
		public Boolean EntireRMAHeaderSetToErrorAcked;

		public Int32? RMAHeaderId;

		public List<VerifiedRMAItem> Items;

		public List<String> Errors;

		public List<String> Info;
	} 
}