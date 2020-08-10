using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ExportRegister
	{
        /// <summary>
        /// The time of which the export query was ran - safer than when the export finished 
        /// </summary>
		public DateTime? LastQueryExecuted { get; set; }

		public Boolean LastExportStatus { get; set; }

		public Int32 Id { get; set; }

		public String Type { get; set; }

		public String FriendlyName { get; set; }

		public Boolean Executing { get; set; }

		public Boolean justOnce { get; set; }

		public DateTime? Started { get; set; }

		public DateTime? Completed { get; set; }

		public Boolean IsQueued { get; set; }

		public Boolean Enabled { get; set; }

		public Boolean IsNew { get; set; }

		public Boolean AllSchedulesDisabled { get; set; }

		public DateTime? NextSchedule { get; set; }
	} 
}