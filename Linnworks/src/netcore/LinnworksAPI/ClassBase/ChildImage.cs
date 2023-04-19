using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChildImage : LinnObject
	{
		public String ImageName { get; set; }

		public String ImageURL { get; set; }

		public String Path { get; set; }

		public Guid ImageId { get; set; }

		public Guid ParentImageId { get; set; }
	} 
}