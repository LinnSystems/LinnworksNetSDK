using System;

namespace LinnworksAPI
{
    public class DateFieldFilter
    {
        public DateTime? DateFrom;
        public DateTime? DateTo;
        public DateTimeFieldFilterType Type;
        public Int32? Value;
        public FieldCode FieldCode;
    }
}