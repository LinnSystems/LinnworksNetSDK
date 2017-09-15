using System;

namespace LinnworksAPI
{
    public class SetOrderPackagingRequest
    {
        public Guid fkPackagingGroupId;
        public Guid fkPackagingTypeId;
        public Guid pkOrderId;
        public Double TotalWeight;
        public Boolean ManualAdjust;
        public Boolean IsAutoSplit;
        public Decimal TotalDepth;
        public Decimal TotalHeight;
        public Decimal TotalWidth;
    }
}