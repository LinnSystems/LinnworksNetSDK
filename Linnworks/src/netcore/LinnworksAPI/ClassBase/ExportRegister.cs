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
		public DateTime? LastQueryExecuted;

		public Boolean LastExportStatus;

		public Int32 Id;

		public String Type;

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