using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RefundError
	{
		public Guid RefundRowId;

		public String ErrorMessage;

		public DateTime DateStamp;

		public Boolean Acknowledged;
	} 
}