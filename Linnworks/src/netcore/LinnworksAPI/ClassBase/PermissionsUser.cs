using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PermissionsUser
	{
		public Int32 UserId;

		public Boolean SuperAdmin;

		public Guid fkUserId;

		public String EmailAddress;

		public String UserType;
	} 
}