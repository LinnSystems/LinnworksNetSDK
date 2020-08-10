using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateRMABookingResponse
	{
		public Int32? RMAHeaderId { get; set; }

		public List<VerifiedRMAItem> Items { get; set; }

		public List<String> Errors { get; set; }

		public List<String> Info { get; set; }
	} 
}