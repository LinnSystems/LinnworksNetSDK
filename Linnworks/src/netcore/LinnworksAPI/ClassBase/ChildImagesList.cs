using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChildImagesList : LinnObject
	{
		public Guid ChildId { get; set; }

		public List<ChildImage> Images { get; set; }
	} 
}