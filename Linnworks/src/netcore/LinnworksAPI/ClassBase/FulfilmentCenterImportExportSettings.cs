using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Fulfilment Center Import and Export Settings 
    /// </summary>
    public class FulfilmentCenterImportExportSettings
	{
        /// <summary>
        /// Stock location ID. 
        /// </summary>
		public Guid fkStockLocationId { get; set; }

        /// <summary>
        /// ID of Order Export if enabled. 
        /// </summary>
		public Int32 fkOrdersExportId { get; set; }

        /// <summary>
        /// ID of Order Import if enabled. 
        /// </summary>
		public Int32 fkOrdersImportId { get; set; }

        /// <summary>
        /// ID of Inventory Import if enabled. 
        /// </summary>
		public Int32 fkInventoryImportId { get; set; }

        /// <summary>
        /// True if Order Export is enabled. 
        /// </summary>
		public Boolean OrdersExportEnabled { get; set; }

        /// <summary>
        /// True if Order Import is enabled. 
        /// </summary>
		public Boolean OrdersImportEnabled { get; set; }

        /// <summary>
        /// True if Inventory Import is enabled. 
        /// </summary>
		public Boolean InventoryImportEnabled { get; set; }
	} 
}