using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinnworksMacroHelpers.Helpers
{
    public class RuntimeHelper
    {
        private readonly DateTime _EstimatedStart = DateTime.UtcNow;
        public DateTime GetEstimatedStartTime()
        {
            return _EstimatedStart;
        }

        public double GetEstimatedRunTime(TimeType type)
        {
            TimeSpan timeDiff = DateTime.UtcNow.Subtract(_EstimatedStart);
            switch (type)
            {
                case TimeType.Minutes:
                    return timeDiff.TotalMinutes;
                case TimeType.Seconds:
                    return timeDiff.TotalSeconds;
                default:
                    throw new NotImplementedException("Time type has not been implemented");
            }
        }

        public double GetEstimatedRunTimeLeft(TimeType type, int maxRuntime)
        {
            TimeSpan timeDiff = DateTime.UtcNow.Subtract(_EstimatedStart);
            switch (type)
            {
                case TimeType.Minutes:
                    return maxRuntime - timeDiff.TotalMinutes;
                case TimeType.Seconds:
                    return maxRuntime - timeDiff.TotalSeconds;
                default:
                    throw new NotImplementedException("Time type has not been implemented");
            }
        }
    }

    public enum TimeType
    {
        Minutes,
        Seconds
    }
}
