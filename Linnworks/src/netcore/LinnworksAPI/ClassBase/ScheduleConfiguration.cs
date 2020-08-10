using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ScheduleConfiguration
	{
        /// <summary>
        /// Just one time or recurrent 
        /// </summary>
		public RepetitionType RepetitionType { get; set; }

		public DateTime? OneTimeDate { get; set; }

        /// <summary>
        /// If is recurrent. Occurs daily or weekly? 
        /// </summary>
		public DailyFrequencyType? DailyFrequency { get; set; }

		public DateTime? OccursFrequencyStartingDate { get; set; }

        /// <summary>
        /// If recurrent, occurs each X times the quantity of 'DailyFrequency' (each 1 day, each 5 days, each 3 weeks, etc...) 
        /// </summary>
		public Int32? OccursFrequencyEveryX { get; set; }

        /// <summary>
        /// If recurrent weekly, indicate what days (i.e '12' -> Monday and Tuesday ) 
        /// </summary>
		public String WeeklyDays { get; set; }

        /// <summary>
        /// If is recurrent, occurs just one time each time, or multiple time (one time each 3 days, or each hour each 3 days) 
        /// </summary>
		public RepetitionType? OccursFrequency { get; set; }

        /// <summary>
        /// If recurrent but just one time each time, what time? 
        /// </summary>
		public String OccursOnceAtTime { get; set; }

        /// <summary>
        /// If recurrent but several times each time, each how many hours 
        /// </summary>
		public Int32? OccursEveryHours { get; set; }

        /// <summary>
        /// If recurrent and several times each time, starting when? 
        /// </summary>
		public String StartingTime { get; set; }

        /// <summary>
        /// If recurrent and several times each time, ending when? 
        /// </summary>
		public String EndingTime { get; set; }

        /// <summary>
        /// Is enabled? NB : with macro schedules this property is not used (enabled exists higher in the data structure). 
        /// </summary>
		public Boolean Enabled { get; set; }
	} 
}