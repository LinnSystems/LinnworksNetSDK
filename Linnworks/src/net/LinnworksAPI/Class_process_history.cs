using System;

namespace LinnworksAPI
{
    public class process_history
    {
        public Guid sid_registration;
        public Guid pkServerId;
        public Guid pkWireId;
        public Int32 pkRowId;
        public Int32 ProcessLaunchVersion;
        public Int32 ProcessId;
        public Int32 OperationCount;
        public Int32 Executions;
        public Int32 WithErrors;
        public Int32 total;
        public String JobType;
        public String JobTypeTitle;
        public String Branch;
        public Double AvgDuration;
        public Double DurationMinutes;
        public Double CPU;
        public Double MemoryEnd;
        public DateTime ProcessStartDateTime;
        public DateTime ProcessEndDatetime;
        public Boolean IsCriticalError;
        public customer Customer;
        public server_register Server;
    }
}