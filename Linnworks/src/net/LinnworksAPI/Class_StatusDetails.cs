using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class StatusDetails
    {
        public StateType State;
        public String Reason;
        public Dictionary<String, String> Parameters;
    }
}