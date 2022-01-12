using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ShipStationConfig
	{
        /// <summary>
        /// Config version (for legacy purposes) 
        /// </summary>
		public Int32 ConfigV { get; set; }

        /// <summary>
        /// A unique identifier for the config within Linnworks 
        /// </summary>
		public String ConfigId { get; set; }

        /// <summary>
        /// An identifier for the config within Linnworks 
        /// </summary>
		public String Name { get; set; }

        /// <summary>
        /// Defines whether the config is enabled 
        /// </summary>
		public Boolean Enabled { get; set; }

        /// <summary>
        /// The order locations to look for orders in 
        /// </summary>
		public HashSet<Guid> ExportLocations { get; set; }

        /// <summary>
        /// The order folder to export orders from 
        /// </summary>
		public Guid ExportFolder { get; set; }

        /// <summary>
        /// The last sync date with ShipStation 
        /// </summary>
		public DateTime LastSync { get; set; }

        /// <summary>
        /// The location to process orders from 
        /// </summary>
		public Guid AutoProcessOrdersLocation { get; set; }

        /// <summary>
        /// Toggles whether or not to export child items 
        /// </summary>
		public Boolean ExportChildItems { get; set; }

        /// <summary>
        /// The order tag to assign ShipStation imported orders 
        /// </summary>
		public Int32 ImportedOrderTag { get; set; }

        /// <summary>
        /// The default ShipStation shipping service 
        /// </summary>
		public Guid DefaultShipServiceShipStation { get; set; }

        /// <summary>
        /// The default Linnworks shipping service 
        /// </summary>
		public Guid DefaultShipServiceLinnworks { get; set; }

        /// <summary>
        /// Toggles between sending channel SKU/Title or linnworks SKU/Title to ShipStation 
        /// </summary>
		public Boolean UseChannelData { get; set; }

        /// <summary>
        /// A list of assigned shipping services 
        /// </summary>
		public List<ShipService> ShipServices { get; set; }

        /// <summary>
        /// The weight unit for order items 
        /// </summary>
		public Weight WeightUnit { get; set; }

        /// <summary>
        /// A custom field allowing user to pass custom information about the order 
        /// </summary>
		public String CustomOrderField1 { get; set; }

        /// <summary>
        /// A custom field allowing user to pass custom information about the order 
        /// </summary>
		public String CustomOrderField2 { get; set; }

        /// <summary>
        /// A custom field allowing user to pass custom information about the order 
        /// </summary>
		public String CustomOrderField3 { get; set; }
	} 
}