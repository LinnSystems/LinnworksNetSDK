using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOrderTrackingURLsResponse : LinnObject
	{
		public List<TrackingURLResponseItem> Items { get; set; }
	} 
}