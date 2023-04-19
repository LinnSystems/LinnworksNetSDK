using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetBinrackByIdRequest : LinnObject
	{
		public IEnumerable<Int32> BinrackIds { get; set; }
	} 
}