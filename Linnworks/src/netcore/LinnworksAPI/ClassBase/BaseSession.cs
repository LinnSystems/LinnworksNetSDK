using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BaseSession
	{
		public Int32? TTL;

		public String Device;

		public String DeviceType;

		public String Server;

		public String PushServer;

		public StatusDetails Status;

		public String BsonId;

		public Guid Id;

		public String Email;

		public Guid UserId;

		public String UserName;

		public String UserType;

		public Guid Token;

		public Guid EntityId;

		public String GroupName;

		public LocalityType Locality;

		public Dictionary<String,String> Properties;
	} 
}