using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SearchBinracksRequest
	{
		public String BinRack;

		public Guid LocationId;

		public List<Int32> BinRackTypeIds;

		public Int32 PageNumber;
	} 
}