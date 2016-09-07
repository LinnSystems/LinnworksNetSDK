using System;

namespace LinnworksAPI
{
    public class OrderShippingInfo
    {
        public String Vendor;
        public Guid PostalServiceId;
        public String PostalServiceName;
        public Double TotalWeight;
        public Double ItemWeight;
        public Guid PackageCategoryId;
        public String PackageCategory;
        public Guid? PackageTypeId;
        public String PackageType;
        public Double PostageCost;
        public Double PostageCostExTax;
        public String TrackingNumber;
        public Boolean ManualAdjust;
    }
}