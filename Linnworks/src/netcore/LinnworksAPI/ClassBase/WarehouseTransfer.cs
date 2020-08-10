using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseTransfer
	{
        /// <summary>
        /// Transfer ID 
        /// </summary>
		public Guid PkTransferId { get; set; }

        /// <summary>
        /// Location from which transfer is made (unique identifier) 
        /// </summary>
		public Guid FromLocationId { get; set; }

        /// <summary>
        /// Location to which transfer is made (unique identifier) 
        /// </summary>
		public Guid ToLocationId { get; set; }

        /// <summary>
        /// Name of location from which transfer is made 
        /// </summary>
		public String FromLocation { get; set; }

        /// <summary>
        /// Name of location to which transfer is made 
        /// </summary>
		public String ToLocation { get; set; }

        /// <summary>
        /// Current transfer status 
        /// </summary>
		public TransferStatus Status { get; set; }

        /// <summary>
        /// Status ID 
        /// </summary>
		public Int32 nStatus { get; set; }

        /// <summary>
        /// Transfer reference number 
        /// </summary>
		public String ReferenceNumber { get; set; }

        /// <summary>
        /// When transer was ordered 
        /// </summary>
		public DateTime OrderDate { get; set; }

        /// <summary>
        /// Number of items transfered 
        /// </summary>
		public Int32 NumberOfItems { get; set; }

        /// <summary>
        /// Number of transfer notes 
        /// </summary>
		public Int32 NumberOfNotes { get; set; }

        /// <summary>
        /// Original transfer ID 
        /// </summary>
		public Guid fkOriginalTransferId { get; set; }

        /// <summary>
        /// Original transfer reference number 
        /// </summary>
		public String OriginalTransferReference { get; set; }

        /// <summary>
        /// If its a discrepency transfer 
        /// </summary>
		public Boolean IsDiscrepancyTransfer { get; set; }

        /// <summary>
        /// If transfer is deleted 
        /// </summary>
		public Boolean BLogicalDelete { get; set; }

        /// <summary>
        /// List of transfer bins 
        /// </summary>
		public List<WarehouseTransferBin> Bins { get; set; }

        /// <summary>
        /// List of transfer notes 
        /// </summary>
		public List<WarehouseTransferNote> Notes { get; set; }

        /// <summary>
        /// List of transfer audits 
        /// </summary>
		public List<WarehouseTransferAudit> AuditTrail { get; set; }

        /// <summary>
        /// List of transfer properties 
        /// </summary>
		public List<WarehouseTransferProperty> TransferProperties { get; set; }

        /// <summary>
        /// Which status is updated 
        /// </summary>
		public UpdateStatus UpdateStatus { get; set; }
	} 
}