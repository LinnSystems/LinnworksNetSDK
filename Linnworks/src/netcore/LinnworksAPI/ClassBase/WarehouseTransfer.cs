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
		public Guid PkTransferId;

        /// <summary>
        /// Location from which transfer is made (unique identifier) 
        /// </summary>
		public Guid FromLocationId;

        /// <summary>
        /// Location to which transfer is made (unique identifier) 
        /// </summary>
		public Guid ToLocationId;

        /// <summary>
        /// Name of location from which transfer is made 
        /// </summary>
		public String FromLocation;

        /// <summary>
        /// Name of location to which transfer is made 
        /// </summary>
		public String ToLocation;

        /// <summary>
        /// Current transfer status 
        /// </summary>
		public TransferStatus Status;

        /// <summary>
        /// Status ID 
        /// </summary>
		public Int32 nStatus;

        /// <summary>
        /// Transfer reference number 
        /// </summary>
		public String ReferenceNumber;

        /// <summary>
        /// When transer was ordered 
        /// </summary>
		public DateTime OrderDate;

        /// <summary>
        /// Number of items transfered 
        /// </summary>
		public Int32 NumberOfItems;

        /// <summary>
        /// Number of transfer notes 
        /// </summary>
		public Int32 NumberOfNotes;

        /// <summary>
        /// Original transfer ID 
        /// </summary>
		public Guid fkOriginalTransferId;

        /// <summary>
        /// Original transfer reference number 
        /// </summary>
		public String OriginalTransferReference;

        /// <summary>
        /// If its a discrepency transfer 
        /// </summary>
		public Boolean IsDiscrepancyTransfer;

        /// <summary>
        /// If transfer is deleted 
        /// </summary>
		public Boolean BLogicalDelete;

        /// <summary>
        /// List of transfer bins 
        /// </summary>
		public List<WarehouseTransferBin> Bins;

        /// <summary>
        /// List of transfer notes 
        /// </summary>
		public List<WarehouseTransferNote> Notes;

        /// <summary>
        /// List of transfer audits 
        /// </summary>
		public List<WarehouseTransferAudit> AuditTrail;

        /// <summary>
        /// List of transfer properties 
        /// </summary>
		public List<WarehouseTransferProperty> TransferProperties;

        /// <summary>
        /// Which status is updated 
        /// </summary>
		public UpdateStatus UpdateStatus;
	} 
}