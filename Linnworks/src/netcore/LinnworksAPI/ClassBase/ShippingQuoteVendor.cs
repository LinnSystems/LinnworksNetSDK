using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Single shipping quote 
    /// </summary>
    public class ShippingQuoteVendor : LinnObject
	{
        /// <summary>
        /// Vendor identifier 
        /// </summary>
		public String Vendor { get; set; }

        /// <summary>
        /// Vendor friendly name 
        /// </summary>
		public String FriendlyName { get; set; }

        /// <summary>
        /// Service vendor name 
        /// </summary>
		public String ServiceVendor { get; set; }

        /// <summary>
        /// Vendor icon 
        /// </summary>
		public String IconURL { get; set; }

        /// <summary>
        /// Integration Account Id 
        /// </summary>
		public String AccountId { get; set; }

        /// <summary>
        /// Service Name 
        /// </summary>
		public String ServiceName { get; set; }

        /// <summary>
        /// Service Code 
        /// </summary>
		public String ServiceCode { get; set; }

        /// <summary>
        /// Service Id - must be unique from the shipping integration 
        /// </summary>
		public Guid ServiceId { get; set; }

        /// <summary>
        /// Service tag, normally this will match the ServiceCode 
        /// </summary>
		public String ServiceTag { get; set; }

        /// <summary>
        /// Earliest available collection date. If the courier doesn't support collection, this will be returned as current UTC time 
        /// </summary>
		public DateTime CollectionDate { get; set; }

        /// <summary>
        /// Estimated delivery date 
        /// </summary>
		public DateTime EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Shipping quote currency 
        /// </summary>
		public String Currency { get; set; }

        /// <summary>
        /// Shipping quote cost  (excluding tax) 
        /// </summary>
		public Decimal Cost { get; set; }

        /// <summary>
        /// Shipping quote tax 
        /// </summary>
		public Decimal Tax { get; set; }

        /// <summary>
        /// Total shipping cost  (including tax) 
        /// </summary>
		public Decimal TotalCost { get; set; }

        /// <summary>
        /// List of shipping quote properties 
        /// </summary>
		public List<QuoteProperty> PropertyItem { get; set; }

        /// <summary>
        /// List of shipping quote options 
        /// </summary>
		public List<QuoteServieOption> Options { get; set; }
	} 
}