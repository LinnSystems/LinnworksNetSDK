using System;

namespace LinnworksAPI
{
    public class jobcode_register
    {
        public Guid pkCodeId;
        public Int32 Version;
        public DateTime UpdateDateTime;
        public String JobType;
        public Double JobAccumulationDelay;
        public Boolean LongRunningJob;
    }
}