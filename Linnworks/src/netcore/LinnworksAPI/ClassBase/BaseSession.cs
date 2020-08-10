using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BaseSession
	{
		public Guid Id;

		public Guid EntityId;

		public String DatabaseName;

		public String DatabaseServer;

		public String PrivateDatabaseServer;

		public String DatabaseUser;

		public String DatabasePassword;

		public Guid sid_registration;

		public String UserName;

		public String Md5Hash;

		public LocalityType Locality;

		public Boolean SuperAdmin;

		public Int32? TTL;

		public Guid Token;

		public String GroupName;

		public String Device;

		public String DeviceType;

		public String UserType;

		public StatusDetails Status;

		public Guid UserId;

		public Dictionary<String,String> Properties;

		public String Email;

		public String Server;

		public String PushServer;
	} 
}