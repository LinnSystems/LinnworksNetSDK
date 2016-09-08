using System;

namespace LinnworksAPI
{
    public class ConfigPaymentMethodMappingItem
    {
        public Int32 fkChannelId;
        public Int32 pkRowId;
        public String Tag;
        public Guid fkBankId;
        public String PaymentMethodName;
        public String Site;
        public Boolean IsChanged;
    }
}