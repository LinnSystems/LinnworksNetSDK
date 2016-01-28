using System;

namespace LinnworksAPI
{
    public class ScheduleConfiguration
    {
        public RepetitionType RepetitionType;
        public DateTime OneTimeDate;
        public DailyFrequencyType DailyFrequency;
        public DateTime OccursFrequencyStartingDate;
        public Int32 OccursFrequencyEveryX;
        public String WeeklyDays;
        public RepetitionType OccursFrequency;
        public String OccursOnceAtTime;
        public Int32 OccursEveryHours;
        public String StartingTime;
        public String EndingTime;
        public Boolean Enabled;
    }
}