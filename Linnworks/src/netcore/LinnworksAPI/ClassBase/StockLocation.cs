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
		public String Address1 { get; set; }

        /// <summary>
        /// 2nd line of address 
        /// </summary>
		public String Address2 { get; set; }

        /// <summary>
        /// City 
        /// </summary>
		public String City { get; set; }

        /// <summary>
        /// County / Region 
        /// </summary>
		public String County { get; set; }

        /// <summary>
        /// Country 
        /// </summary>
		public String Country { get; set; }

        /// <summary>
        /// Postal code 
        /// </summary>
		public String ZipCode { get; set; }

        /// <summary>
        /// Not trackable 
        /// </summary>
		public Boolean IsNotTrackable { get; set; }

        /// <summary>
        /// Location tag 
        /// </summary>
		public String LocationTag { get; set; }

        /// <summary>
        /// Count in order 
        /// </summary>
		public Boolean CountInOrderUntilAcknowledgement { get; set; }

        /// <summary>
        /// Fulfilment center and stock will be deducted when order processed 
        /// </summary>
		public Boolean FulfilmentCenterDeductStockWhenProcessed { get; set; }

        /// <summary>
        /// Indicates if the location is warehosue managed. 
        /// </summary>
		public Boolean IsWarehouseManaged { get; set; }

		public Guid StockLocationId { get; set; }

		public String LocationName { get; set; }

		public Boolean IsFulfillmentCenter { get; set; }

		public Int32 StockLocationIntId { get; set; }
	} 
}