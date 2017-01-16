using System;

namespace LinnworksAPI
{
    public class AddImageToInventoryItemResponse
    {
        public Guid StockItemId;
        public Guid ImageId;
        public String ImageUrl;
        public String ImageThumbnailUrl;
    }
}