using System;

namespace LinnworksAPI
{
    public class ExportRegister
    {
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