using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PermissionsUser
	{
		public Int32 UserId { get; set; }

		public Boolean SuperAdmin { get; set; }

		public Guid fkUserId { get; set; }

		public String EmailAddress { get; set; }

		public String UserType { get; set; }

		public Boolean TotpAuthenticationEnabled { get; set; }
	} 
}