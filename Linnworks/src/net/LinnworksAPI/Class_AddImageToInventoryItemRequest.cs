using System;

namespace LinnworksAPI
{
    public class AddImageToInventoryItemRequest
    {
        public String ItemNumber;
        public Guid StockItemId;
        public Boolean IsMain;
        public String ImageUrl;
    }
}