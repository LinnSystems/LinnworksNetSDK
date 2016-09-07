using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class WarehouseTransfer
    {
        public Guid PkTransferId;
        public Guid FromLocationId;
        public Guid ToLocationId;
        public String FromLocation;
        public String ToLocation;
        public TransferStatus Status;
        public Int32 nStatus;
        public String ReferenceNumber;
        public DateTime OrderDate;
        public Int32 NumberOfItems;
        public Int32 NumberOfNotes;
        public Guid fkOriginalTransferId;
        public String OriginalTransferReference;
        public Boolean IsDiscrepancyTransfer;
        public Boolean BLogicalDelete;
        public List<WarehouseTransferBin> Bins;
        public List<WarehouseTransferNote> Notes;
        public List<WarehouseTransferAudit> AuditTrail;
        public List<WarehouseTransferProperty> TransferProperties;
        public UpdateStatus UpdateStatus;
    }
}