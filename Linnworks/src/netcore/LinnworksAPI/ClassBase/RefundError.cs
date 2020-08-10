using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RefundError
	{
		public Guid RefundRowId { get; set; }

		public String ErrorMessage { get; set; }

		public DateTime DateStamp { get; set; }

		public Boolean Acknowledged { get; set; }
	} 
}