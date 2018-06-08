using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Stock Location 
    /// </summary>
    public class StockLocation
	{
        /// <summary>
        /// 1st line of address 
        /// </summary>
		public String Address1;

        /// <summary>
        /// 2nd line of address 
        /// </summary>
		public String Address2;

        /// <summary>
        /// City 
        /// </summary>
		public String City;

        /// <summary>
        /// County / Region 
        /// </summary>
		public String County;

        /// <summary>
        /// Country 
        /// </summary>
		public String Country;

        /// <summary>
        /// Postal code 
        /// </summary>
		public String ZipCode;

        /// <summary>
        /// Not trackable 
        /// </summary>
		public Boolean IsNotTrackable;

        /// <summary>
        /// Location tag 
        /// </summary>
		public String LocationTag;

        /// <summary>
        /// Count in order 
        /// </summary>
		public Boolean CountInOrderUntilAcknowledgement;

        /// <summary>
        /// Fulfilment center and stock will be deducted when order processed 
        /// </summary>
		public Boolean FulfilmentCenterDeductStockWhenProcessed;

		public Boolean IsWarehouseManaged;

		public Guid StockLocationId;

		public String LocationName;

		public Boolean IsFulfillmentCenter;
	} 
}