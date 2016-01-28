using System;

namespace LinnworksAPI
{
    public class ChannelPaymentMethod
    {
        public Int32 fkChannelId;
        public Int32 pkRowId;
        public String FriendlyName;
        public String Tag;
        public String Site;
        public Boolean IsChanged;
    }
}