using System;

namespace LinnworksAPI
{
    public class UserOrderView
    {
        public DateTime ModifiedDateTime;
        public Int32 pkViewId;
        public String ViewName;
        public String OwnerName;
        public Boolean? AllowModify;
        public String JSONDetail;
    }
}