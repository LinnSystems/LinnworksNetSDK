using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RMAError
	{
		public Int32 RMARowId { get; set; }

		public String ErrorMessage { get; set; }

		public DateTime DateStamp { get; set; }

		public Boolean Acknowledged { get; set; }
	} 
}