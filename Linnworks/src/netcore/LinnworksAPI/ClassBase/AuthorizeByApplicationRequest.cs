using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AuthorizeByApplicationRequest
	{
		public Guid ApplicationId;

		public Guid ApplicationSecret;

		public Guid Token;
	} 
}