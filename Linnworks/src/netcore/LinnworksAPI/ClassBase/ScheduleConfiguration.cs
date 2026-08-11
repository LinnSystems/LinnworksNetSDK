using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ScheduleConfiguration : LinnObject
	{
		public RepetitionType RepetitionType { get; set; }

		public DateTime? OneTimeDate { get; set; }

		public DailyFrequencyType? DailyFrequency { get; set; }

		public DateTime? OccursFrequencyStartingDate { get; set; }

		public Int32? OccursFrequencyEveryX { get; set; }

		public String WeeklyDays { get; set; }

		public RepetitionType? OccursFrequency { get; set; }

		public String OccursOnceAtTime { get; set; }

		public Int32? OccursEveryHours { get; set; }

		public String StartingTime { get; set; }

		public String EndingTime { get; set; }

		public Boolean Enabled { get; set; }
	} 
}