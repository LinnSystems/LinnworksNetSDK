using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ViewUser
	{
		public String Name { get; set; }

		public Boolean IsOwner { get; set; }

		public Int32 UserId { get; set; }

		public String EmailAddress { get; set; }

		public String UserType { get; set; }
	} 
}