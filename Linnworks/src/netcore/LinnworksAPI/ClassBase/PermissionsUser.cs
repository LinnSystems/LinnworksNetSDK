using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PermissionsUser
	{
        /// <summary>
        /// User ID 
        /// </summary>
		public Int32 UserId;

        /// <summary>
        /// If user is super admin 
        /// </summary>
		public Boolean SuperAdmin;

        /// <summary>
        /// User ID. (SID registration) 
        /// </summary>
		public Guid fkUserId;

        /// <summary>
        /// User email address 
        /// </summary>
		public String EmailAddress;

        /// <summary>
        /// User type (e.g. User, Application) 
        /// </summary>
		public String UserType;
	} 
}