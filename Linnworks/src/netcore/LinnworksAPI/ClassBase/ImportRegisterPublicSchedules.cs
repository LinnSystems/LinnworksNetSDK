using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ImportRegisterPublicSchedules
	{
		public List<Schedule> Schedules { get; set; }

		public String LastFileChecksum { get; set; }

		public String ImportStatus { get; set; }

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