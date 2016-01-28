using System;

namespace LinnworksAPI
{
    public class OrdersAppSettings
    {
        public Boolean SelectingOrderBringItIntoView;
        public Int32 NumberOfItems;
        public Boolean ShowCompleteAndProcessButton;
        public Boolean ShowStockLevelTooltip;
        public String ThumbnailSize;
        public Boolean AutoPrintLabel;
        public Boolean AutoPrintInvoice;
        public Boolean SpaceBarToProcessOrder;
        public String ProcessOrderByScanningBarcode;
        public Boolean ScanTrackingNumber;
        public String DefaultTabOnDespatchConsole;
        public Boolean ExcludeUnpaidForItemBarcode;
    }
}