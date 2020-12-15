using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// ScheduleConfiguration is shared between schduled macros and imports (I expect there is also a variety for exports)
        /// Within imports there is a Schedule class which contains a Name property but it is an import specfic class and reuse would require changes to the underlying macro data structure
        /// Hence NamedScheduleConfiguration - written for use by Macros but hopefully we'll be able to move all scheduling into the namespace eventually 
    /// </summary>
    public class NamedScheduleConfiguration
	{
        /// <summary>
        /// User visible name for a schedule configuration 
        /// </summary>
		public String Name { get; set; }

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