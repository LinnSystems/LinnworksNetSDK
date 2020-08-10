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
		public String Vendor { get; set; }

        /// <summary>
        /// Postal service ID 
        /// </summary>
		public Guid PostalServiceId { get; set; }

        /// <summary>
        /// Postal service name (e.g. Next day delivery) 
        /// </summary>
		public String PostalServiceName { get; set; }

        /// <summary>
        /// Order total weight 
        /// </summary>
		public Decimal TotalWeight { get; set; }

        /// <summary>
        /// If order is processed 
        /// </summary>
		public Decimal ItemWeight { get; set; }

        /// <summary>
        /// Package category ID 
        /// </summary>
		public Guid PackageCategoryId { get; set; }

        /// <summary>
        /// Package category name 
        /// </summary>
		public String PackageCategory { get; set; }

        /// <summary>
        /// Package type ID 
        /// </summary>
		public Guid? PackageTypeId { get; set; }

        /// <summary>
        /// Package type name 
        /// </summary>
		public String PackageType { get; set; }

        /// <summary>
        /// Order postage cost 
        /// </summary>
		public Double PostageCost { get; set; }

        /// <summary>
        /// Order postage cost excluding tax 
        /// </summary>
		public Double PostageCostExTax { get; set; }

        /// <summary>
        /// Order tracking number provided by courier 
        /// </summary>
		public String TrackingNumber { get; set; }

        /// <summary>
        /// If there is an adjustment to shipping cost was made 
        /// </summary>
		public Boolean ManualAdjust { get; set; }
	} 
}