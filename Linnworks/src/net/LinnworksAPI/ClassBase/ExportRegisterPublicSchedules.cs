using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{ 
	public class ExportRegisterPublicSchedules
	{ 
		public DateTime? LastQueryExecuted;
		public List<Schedule> Schedules;
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