using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class APIResultResponse<Guid> : LinnObject
	{
		public Guid Result { get; set; }

		public APIResultStatus ResultStatus { get; set; }

		public String Message { get; set; }
	} 
}