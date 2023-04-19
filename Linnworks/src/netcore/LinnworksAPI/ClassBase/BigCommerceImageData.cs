using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BigCommerceImageData : LinnObject
	{
		public Int32 Id { get; set; }

		public Boolean Thumb { get; set; }

		public Int32 sortOrder { get; set; }

		public Boolean IsChild { get; set; }

		public Guid ImageId { get; set; }

		public String URL { get; set; }

		public String Label { get; set; }

		public Boolean Show { get; set; }

		public Boolean IsNative { get; set; }
	} 
}