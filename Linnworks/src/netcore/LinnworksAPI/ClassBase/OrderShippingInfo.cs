using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderShippingInfo
	{
        /// <summary>
        /// Courier name (e.g. Royal Mail) 
        /// </summary>
		public String Vendor;

        /// <summary>
        /// Postal service ID 
        /// </summary>
		public Guid PostalServiceId;

        /// <summary>
        /// Postal service name (e.g. Next day delivery) 
        /// </summary>
		public String PostalServiceName;

        /// <summary>
        /// Order total weight 
        /// </summary>
		public Decimal TotalWeight;

        /// <summary>
        /// If order is processed 
        /// </summary>
		public Decimal ItemWeight;

        /// <summary>
        /// Package category ID 
        /// </summary>
		public Guid PackageCategoryId;

        /// <summary>
        /// Package category name 
        /// </summary>
		public String PackageCategory;

        /// <summary>
        /// Package type ID 
        /// </summary>
		public Guid? PackageTypeId;

        /// <summary>
        /// Package type name 
        /// </summary>
		public String PackageType;

        /// <summary>
        /// Order postage cost 
        /// </summary>
		public Double PostageCost;

        /// <summary>
        /// Order postage cost excluding tax 
        /// </summary>
		public Double PostageCostExTax;

        /// <summary>
        /// Order tracking number provided by courier 
        /// </summary>
		public String TrackingNumber;

        /// <summary>
        /// If there is an adjustment to shipping cost was made 
        /// </summary>
		public Boolean ManualAdjust;
	} 
}