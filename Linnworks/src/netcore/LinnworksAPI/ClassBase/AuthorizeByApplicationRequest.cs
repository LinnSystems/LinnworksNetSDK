using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AuthorizeByApplicationRequest
	{
		public Guid ApplicationId { get; set; }

		public Guid ApplicationSecret { get; set; }

		public Guid Token { get; set; }
	} 
}