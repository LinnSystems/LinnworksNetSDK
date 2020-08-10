using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ImportRegister
	{
		public String LastFileChecksum { get; set; }

        /// <summary>
        /// Current import status 
        /// </summary>
		public String ImportStatus { get; set; }

        /// <summary>
        /// If import was skipped 
        /// </summary>
		public Boolean ImportSkipped { get; set; }

		public Int32 Id { get; set; }

		public ImportType Type { get; set; }

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