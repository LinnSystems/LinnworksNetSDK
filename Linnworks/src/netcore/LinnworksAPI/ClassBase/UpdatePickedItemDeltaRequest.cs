using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdatePickedItemDeltaRequest : LinnObject
	{
		public List<UpdatePickedItemDeltaRequestItem> Deltas { get; set; }
	} 
}