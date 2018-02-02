using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetJobByNameRequest
	{
        /// <summary>
        /// Job name to find 
        /// </summary>
		public String JobName;

        /// <summary>
        /// Supply if the job should only exist in a location 
        /// </summary>
		public Guid? LocationId;
	} 
}