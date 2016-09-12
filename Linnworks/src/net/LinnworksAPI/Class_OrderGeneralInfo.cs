using System;

namespace LinnworksAPI
{
    [Serializable]
    public class OrderGeneralInfo
    {
        public Int32 Status;
        public Boolean LabelPrinted;
        public String LabelError;
        public Boolean InvoicePrinted;
        public Boolean PickListPrinted;
        public Int32 Notes;
        public Boolean PartShipped;
        public Byte? Marker;
        public String ReferenceNum;
        public String SecondaryReference;
        public String ExternalReferenceNum;
        public DateTime ReceivedDate;
        public String Source;
        public String SubSource;
        public Boolean HoldOrCancel;
        public DateTime DespatchByDate;
        public Guid Location;
        public Int32 NumItems;
    }
}