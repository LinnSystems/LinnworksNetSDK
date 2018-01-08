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
	public class ScheduleConfiguration
	{ 
		public RepetitionType RepetitionType;
		public DateTime? OneTimeDate;
		public DailyFrequencyType? DailyFrequency;
		public DateTime? OccursFrequencyStartingDate;
		public Int32? OccursFrequencyEveryX;
		public String WeeklyDays;
		public RepetitionType? OccursFrequency;
		public String OccursOnceAtTime;
		public Int32? OccursEveryHours;
		public String StartingTime;
		public String EndingTime;
		public Boolean Enabled;
	} 
}