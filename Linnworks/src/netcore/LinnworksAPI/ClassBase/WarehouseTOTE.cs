using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Represents Warehouse TOT 
    /// </summary>
    public class WarehouseTOTE
	{
        /// <summary>
        /// Tote Id 
        /// </summary>
		public Int32 ToteId;

        /// <summary>
        /// TOTE Barcode 
        /// </summary>
		public String ToteBarcode;

        /// <summary>
        /// Location Id of a warehouse to which TOT belongs 
        /// </summary>
		public Guid LocationId;
	} 
}