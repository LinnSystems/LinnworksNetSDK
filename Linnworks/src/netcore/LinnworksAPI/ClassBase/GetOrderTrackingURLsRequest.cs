using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOrderTrackingURLsRequest : LinnObject
	{
		public List<TrackingURLRequestItem> Items { get; set; }
	} 
}