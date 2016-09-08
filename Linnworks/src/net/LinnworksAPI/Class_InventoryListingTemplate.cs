using System;

namespace LinnworksAPI
{
    public class InventoryListingTemplate
    {
        public Boolean IsErrorMsg;
        public String Status;
        public DateTime? CreatedDate;
        public Guid InventoryItemId;
        public String Source;
        public String SubSource;
        public String CombinedSource;
    }
}