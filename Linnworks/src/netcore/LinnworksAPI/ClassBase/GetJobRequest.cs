using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Request class for GetJob 
    /// </summary>
    public class GetJobRequest : LinnObject
	{
        /// <summary>
        /// Job Id to retrive 
        /// </summary>
		public Int32 JobId { get; set; }
	} 
}