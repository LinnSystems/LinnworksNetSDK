using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ImportRegister
	{
		public String LastFileChecksum;

        /// <summary>
        /// Current import status 
        /// </summary>
		public String ImportStatus;

        /// <summary>
        /// If import was skipped 
        /// </summary>
		public Boolean ImportSkipped;

		public Int32 Id;

		public ImportType Type;

		public String FriendlyName;

		public Boolean Executing;

		public Boolean justOnce;

		public DateTime? Started;

		public DateTime? Completed;

		public Boolean IsQueued;

		public Boolean Enabled;

		public Boolean IsNew;

		public Boolean AllSchedulesDisabled;

		public DateTime? NextSchedule;
	} 
}