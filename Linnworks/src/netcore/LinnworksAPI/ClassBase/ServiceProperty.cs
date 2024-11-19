using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ServiceProperty : LinnObject
	{
		public String PropertyName { get; set; }

		public String PropertyValue { get; set; }

		public Guid ServiceId { get; set; }
	} 
}