using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BatchedAPIResponse<Guid> : LinnObject
	{
		public List<APIResultResponse<Guid>> Results { get; set; }

		public Int32 TotalResults { get; set; }

		public APIResultStatus ResultStatus { get; set; }
	} 
}