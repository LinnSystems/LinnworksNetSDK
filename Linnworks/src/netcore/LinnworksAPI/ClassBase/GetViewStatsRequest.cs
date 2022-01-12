using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetViewStatsRequest
	{
		public Guid LocationId { get; set; }

		public Int32? ViewId { get; set; }

		public Int32? UserId { get; set; }

		public Boolean IncludeUserManagement { get; set; }

		public Boolean OnlyVisible { get; set; }

        /// <summary>
        /// If only the currently built stats are required, pass false here. Useful for polling whether a long running cache build has finished
        /// The default is true. 
        /// </summary>
		public Boolean RebuildCacheIfRequired { get; set; }
	} 
}