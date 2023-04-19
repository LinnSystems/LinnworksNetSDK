using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class MagentoImageData : LinnObject
	{
		public Boolean Base { get; set; }

		public Boolean Small { get; set; }

		public Boolean Thumb { get; set; }

		public Boolean IsChild { get; set; }

		public Guid ImageId { get; set; }

		public String URL { get; set; }

		public String Label { get; set; }

		public Boolean Show { get; set; }

		public Boolean IsNative { get; set; }
	} 
}