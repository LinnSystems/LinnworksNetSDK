using System;

namespace LinnworksAPI
{
    public class ApplicationProfileResponse
    {
        public String PlanTag;
        public String PlanName;
        public DateTime ActivationDate;
        public DateTime LastPaymentDate;
        public DateTime NextPaymentDate;
        public DateTime ProfileExpires;
        public Boolean IsProfileActive;
    }
}