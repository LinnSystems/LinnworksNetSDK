using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ClearStockAssignmentRequest : LinnObject
	{
		public Int32[] OrderIds { get; set; }
	} 
}