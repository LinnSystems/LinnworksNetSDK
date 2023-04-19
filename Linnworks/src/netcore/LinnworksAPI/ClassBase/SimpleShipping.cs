using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SimpleShipping : LinnObject
	{
		public LinnLiveKeyValue ExpeditedShipping { get; set; }

		public LinnLiveKeyValue WillShipInternationally { get; set; }
	} 
}