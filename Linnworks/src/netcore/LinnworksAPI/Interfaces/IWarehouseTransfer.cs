using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IWarehouseTransferController
	{
		AddItemsToTransferResponse AddItemsToTransfer(AddItemsToTransferRequest request);
		WarehouseTransferItem AddItemToTransfer(Guid fkTransferId,Guid pkStockItemId);
		Guid AddTransferBinNote(Guid fkTransferBinId,String note,Guid fkTransferId);
		Guid AddTransferItemNote(Guid fkTransferId,Guid fkTransferItemId,String note);
		Guid AddTransferNote(Guid pkTransferId,String note);
		Guid AddTransferProperty(Guid fkTransferId,String propertyName,String propertyValue);
		Int32 AllocateItemToBin(Guid pkSrcBinId,Guid pkDstBinId,Guid pkTransferItemId,Int32 quantity);
		void ChangeBinDetails(Guid pkTransferId,Guid pkBinId,String BinName,String BinReference,String BinBarcode);
		void ChangeTransferFromLocation(Guid pkTransferId,Guid newLocationId);
		void ChangeTransferItemReceivedQuantity(Guid pkTransferId,Guid pkBinId,Guid pkTransferItemId,Int32? Quantity);
		void ChangeTransferItemRequestQuantity(Guid pkTransferId,Guid pkTransferItemId,Int32 Quantity);
		WarehouseTransferItem ChangeTransferItemSentQuantity(Guid pkTransferId,Guid pkBinId,Guid pkTransferItemId,Int32 Quantity);
		void ChangeTransferLocations(Guid pkTransferId,Guid fromLocationId,Guid toLocationId);
		void ChangeTransferProperty(Guid pkTransferId,Guid pkTransferPropertyId,String newValue);
		void ChangeTransferStatus(Guid pkTransferId,TransferStatus newStatus);
		void ChangeTransferToLocation(Guid pkTransferId,Guid newLocationId);
		Guid CheckForDraftTransfer(Guid toLocationId,Guid fromLocationId);
		WarehouseTransferBin CreateNewBin(Guid pkTransferId,String barcode);
		WarehouseTransfer CreateTransferFromDescrepancies(Guid pkTransferId);
		WarehouseTransfer CreateTransferRequestWithReturn(Guid fromLocationId,Guid toLocationId);
		void DeleteEmptyDraftTransfer(Guid pkTransferId);
		void DeleteTransfer(Guid pkTransferId,String DeleteReason);
		void DeleteTransferProperty(Guid pkTransferId,Guid pkTransferPropertyId);
		List<WarehouseTransfer> GetActiveTransfersAllLocations();
		List<WarehouseTransfer> GetActiveTransfersForLocation(Guid locationId);
		GenericPagedResult<WarehouseTransfer> GetArchivedTransfers(Int32 pageNumber,Int32 entriesPerPage);
		GenericPagedResult<WarehouseTransfer> GetArchivedTransfersBetweenArchivedDates(DateTime start,DateTime end,Int32 pageNumber,Int32 entriesPerPage);
		GenericPagedResult<WarehouseTransfer> GetArchivedTransfersBetweenDates(DateTime start,DateTime end,Int32 pageNumber,Int32 entriesPerPage);
		GenericPagedResult<WarehouseTransfer> GetArchivedTransfersFiltered(SearchType searchType,String filter,Int32 pageNumber,Int32 entriesPerPage);
		List<WarehouseTransferItem> GetDiscrepancyItems(Guid pkTransferId);
		List<WarehouseTransfer> GetListTransfers(List<Guid> ids);
		List<WarehouseTransfer> GetModifiedBasic(DateTime updateDate);
		DateTime GetServerTime();
		List<StockAvailability> GetStockAvailability(Guid pkTransferItemId);
		List<WarehouseTransferAudit> GetTransferAudit(Guid pkTransferId);
		List<WarehouseTransferBinNote> GetTransferBinNotes(Guid pkBinId);
		List<WarehouseTransferItemNote> GetTransferItemNotes(Guid pkTransferId,Guid pkTransferItemId);
		List<WarehouseTransferItem> GetTransferItems(Guid pkTransferId);
		List<WarehouseTransferNote> GetTransferNotes(Guid pkTransferId);
		List<WarehouseTransferProperty> GetTransferProperties(Guid pkTransferId);
		WarehouseTransfer GetTransferWithItems(Guid pkTransferId);
		WarehouseTransfer GetTransferWithNotes(Guid pkTransferId);
		Boolean IsDraftTransferChanged(Guid pkTransferId);
		String PrintTransfer(Guid pkTransferId);
		void RemoveAllEmptyBins();
		void RemoveItemFromTransfer(Guid pkTransferId,Guid pkTransferItemId);
		List<Guid> SearchTransfersAllLocations(SearchType searchType,String searchText);
		List<Guid> SearchTransfersByLocation(SearchType searchType,String searchText,Guid locationID);
		void SetReferenceNumber(Guid pkTransferId,String ReferenceNumber);
	} 
}