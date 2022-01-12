using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BaseSession
	{
		public Guid Id { get; set; }

		public Guid EntityId { get; set; }

		public String DatabaseName { get; set; }

		public String DatabaseServer { get; set; }

		public String PrivateDatabaseServer { get; set; }

		public String DatabaseUser { get; set; }

		public String DatabasePassword { get; set; }

		public String AppName { get; set; }

		public Guid sid_registration { get; set; }

		public String UserName { get; set; }

		public String Md5Hash { get; set; }

		public LocalityType Locality { get; set; }

		public Boolean SuperAdmin { get; set; }

		public Int32? TTL { get; set; }

		public Guid Token { get; set; }

		public String AccessToken { get; set; }

		public String GroupName { get; set; }

		public String Device { get; set; }

		public String DeviceType { get; set; }

		public String UserType { get; set; }

		public StatusDetails Status { get; set; }

		public Guid UserId { get; set; }

		public Dictionary<String,String> Properties { get; set; }

		public String Email { get; set; }

		public String Server { get; set; }

		public String PushServer { get; set; }
	} 
}