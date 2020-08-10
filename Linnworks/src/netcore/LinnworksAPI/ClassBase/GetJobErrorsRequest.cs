using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetJobErrorsRequest
	{
        /// <summary>
        /// Job id for which you want the get the error list 
        /// </summary>
		public Int32 JobId { get; set; }
	} 
}