using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderViewUserPreference : LinnObject
	{
		public Int32 ViewId { get; set; }

		public Boolean IsVisible { get; set; }

		public Byte Sequence { get; set; }
	} 
}