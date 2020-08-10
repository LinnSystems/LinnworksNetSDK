using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetWarehouseTotesRequest
	{
        /// <summary>
        /// Location Id of the TOTs 
        /// </summary>
		public Guid LocationId { get; set; }

        /// <summary>
        /// (Optional) Barcode of the TOT. If provided the response will contain one record that matches exactly to the TotBarcode or returns an empty response if nothing is found. If not provided, empty string or null and TotId is null or not specified all TOTs for the warehouse will be returned. 
        /// </summary>
		public String ToteBarcode { get; set; }

        /// <summary>
        /// (Optional) Id of the TOT, if specified TotBarcode is ignored. If null and TotBarcode not specified then returns all tots in the warehouse 
        /// </summary>
		public Int32? TotId { get; set; }
	} 
}