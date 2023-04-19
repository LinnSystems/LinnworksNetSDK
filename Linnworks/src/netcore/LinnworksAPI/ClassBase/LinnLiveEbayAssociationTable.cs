using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class LinnLiveEbayAssociationTable : LinnObject
	{
		public String TableName { get; set; }

		public String Source { get; set; }

		public String Destination { get; set; }
	} 
}