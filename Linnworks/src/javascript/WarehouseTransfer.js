var WarehouseTransfer =
{
	// http://apidoc.linnworks.net/#/WarehouseTransfer-AddItemToTransfer
	AddItemToTransfer: function(fkTransferId,pkStockItemId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/AddItemToTransfer", token, server, "fkTransferId=" + fkTransferId + "&pkStockItemId=" + pkStockItemId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-AddTransferBinNote
	AddTransferBinNote: function(fkTransferBinId,note,fkTransferId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/AddTransferBinNote", token, server, "fkTransferBinId=" + fkTransferBinId + "&note=" + note + "&fkTransferId=" + fkTransferId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-AddTransferItemNote
	AddTransferItemNote: function(fkTransferId,fkTransferItemId,note,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/AddTransferItemNote", token, server, "fkTransferId=" + fkTransferId + "&fkTransferItemId=" + fkTransferItemId + "&note=" + note +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-AddTransferNote
	AddTransferNote: function(pkTransferId,note,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/AddTransferNote", token, server, "pkTransferId=" + pkTransferId + "&note=" + note +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-AddTransferProperty
	AddTransferProperty: function(fkTransferId,propertyName,propertyValue,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/AddTransferProperty", token, server, "fkTransferId=" + fkTransferId + "&propertyName=" + propertyName + "&propertyValue=" + propertyValue +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-AllocateItemToBin
	AllocateItemToBin: function(pkSrcBinId,pkDstBinId,pkTransferItemId,quantity,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/AllocateItemToBin", token, server, "pkSrcBinId=" + pkSrcBinId + "&pkDstBinId=" + pkDstBinId + "&pkTransferItemId=" + pkTransferItemId + "&quantity=" + quantity +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-ChangeBinDetails
	ChangeBinDetails: function(pkTransferId,pkBinId,BinName,BinReference,BinBarcode,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/ChangeBinDetails", token, server, "pkTransferId=" + pkTransferId + "&pkBinId=" + pkBinId + "&BinName=" + BinName + "&BinReference=" + BinReference + "&BinBarcode=" + BinBarcode +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-ChangeTransferFromLocation
	ChangeTransferFromLocation: function(pkTransferId,newLocationId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/ChangeTransferFromLocation", token, server, "pkTransferId=" + pkTransferId + "&newLocationId=" + newLocationId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-ChangeTransferItemReceivedQuantity
	ChangeTransferItemReceivedQuantity: function(pkTransferId,pkBinId,pkTransferItemId,Quantity,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/ChangeTransferItemReceivedQuantity", token, server, "pkTransferId=" + pkTransferId + "&pkBinId=" + pkBinId + "&pkTransferItemId=" + pkTransferItemId + "&Quantity=" + JSON.stringify(Quantity) +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-ChangeTransferItemRequestQuantity
	ChangeTransferItemRequestQuantity: function(pkTransferId,pkTransferItemId,Quantity,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/ChangeTransferItemRequestQuantity", token, server, "pkTransferId=" + pkTransferId + "&pkTransferItemId=" + pkTransferItemId + "&Quantity=" + Quantity +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-ChangeTransferItemSentQuantity
	ChangeTransferItemSentQuantity: function(pkTransferId,pkBinId,pkTransferItemId,Quantity,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/ChangeTransferItemSentQuantity", token, server, "pkTransferId=" + pkTransferId + "&pkBinId=" + pkBinId + "&pkTransferItemId=" + pkTransferItemId + "&Quantity=" + Quantity +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-ChangeTransferLocations
	ChangeTransferLocations: function(pkTransferId,fromLocationId,toLocationId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/ChangeTransferLocations", token, server, "pkTransferId=" + pkTransferId + "&fromLocationId=" + fromLocationId + "&toLocationId=" + toLocationId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-ChangeTransferProperty
	ChangeTransferProperty: function(pkTransferId,pkTransferPropertyId,newValue,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/ChangeTransferProperty", token, server, "pkTransferId=" + pkTransferId + "&pkTransferPropertyId=" + pkTransferPropertyId + "&newValue=" + newValue +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-ChangeTransferStatus
	ChangeTransferStatus: function(pkTransferId,newStatus,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/ChangeTransferStatus", token, server, "pkTransferId=" + pkTransferId + "&newStatus=" + newStatus +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-ChangeTransferToLocation
	ChangeTransferToLocation: function(pkTransferId,newLocationId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/ChangeTransferToLocation", token, server, "pkTransferId=" + pkTransferId + "&newLocationId=" + newLocationId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-CheckForDraftTransfer
	CheckForDraftTransfer: function(toLocationId,fromLocationId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/CheckForDraftTransfer", token, server, "toLocationId=" + toLocationId + "&fromLocationId=" + fromLocationId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-CreateNewBin
	CreateNewBin: function(pkTransferId,barcode,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/CreateNewBin", token, server, "pkTransferId=" + pkTransferId + "&barcode=" + barcode +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-CreateTransferFromDescrepancies
	CreateTransferFromDescrepancies: function(pkTransferId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/CreateTransferFromDescrepancies", token, server, "pkTransferId=" + pkTransferId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-CreateTransferRequestWithReturn
	CreateTransferRequestWithReturn: function(fromLocationId,toLocationId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/CreateTransferRequestWithReturn", token, server, "fromLocationId=" + fromLocationId + "&toLocationId=" + toLocationId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-DeleteEmptyDraftTransfer
	DeleteEmptyDraftTransfer: function(pkTransferId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/DeleteEmptyDraftTransfer", token, server, "pkTransferId=" + pkTransferId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-DeleteTransfer
	DeleteTransfer: function(pkTransferId,DeleteReason,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/DeleteTransfer", token, server, "pkTransferId=" + pkTransferId + "&DeleteReason=" + DeleteReason +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-DeleteTransferProperty
	DeleteTransferProperty: function(pkTransferId,pkTransferPropertyId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/DeleteTransferProperty", token, server, "pkTransferId=" + pkTransferId + "&pkTransferPropertyId=" + pkTransferPropertyId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetActiveTransfersAllLocations
	GetActiveTransfersAllLocations: function(token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetActiveTransfersAllLocations", token, server, "");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetActiveTransfersForLocation
	GetActiveTransfersForLocation: function(locationId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetActiveTransfersForLocation", token, server, "locationId=" + locationId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetArchivedTransfers
	GetArchivedTransfers: function(pageNumber,entriesPerPage,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetArchivedTransfers", token, server, "pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetArchivedTransfersBetweenDates
	GetArchivedTransfersBetweenDates: function(start,end,pageNumber,entriesPerPage,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetArchivedTransfersBetweenDates", token, server, "start=" + JSON.stringify(start) + "&end=" + JSON.stringify(end) + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetArchivedTransfersFiltered
	GetArchivedTransfersFiltered: function(searchType,filter,pageNumber,entriesPerPage,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetArchivedTransfersFiltered", token, server, "searchType=" + searchType + "&filter=" + filter + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetDiscrepancyItems
	GetDiscrepancyItems: function(pkTransferId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetDiscrepancyItems", token, server, "pkTransferId=" + pkTransferId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetListTransfers
	GetListTransfers: function(ids,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetListTransfers", token, server, "ids=" + JSON.stringify(ids) +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetModifiedBasic
	GetModifiedBasic: function(updateDate,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetModifiedBasic", token, server, "updateDate=" + JSON.stringify(updateDate) +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetServerTime
	GetServerTime: function(token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetServerTime", token, server, "");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetStockAvailability
	GetStockAvailability: function(pkTransferItemId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetStockAvailability", token, server, "pkTransferItemId=" + pkTransferItemId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetTransferAudit
	GetTransferAudit: function(pkTransferId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetTransferAudit", token, server, "pkTransferId=" + pkTransferId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetTransferBinNotes
	GetTransferBinNotes: function(pkBinId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetTransferBinNotes", token, server, "pkBinId=" + pkBinId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetTransferItemNotes
	GetTransferItemNotes: function(pkTransferId,pkTransferItemId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetTransferItemNotes", token, server, "pkTransferId=" + pkTransferId + "&pkTransferItemId=" + pkTransferItemId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetTransferItems
	GetTransferItems: function(pkTransferId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetTransferItems", token, server, "pkTransferId=" + pkTransferId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetTransferNotes
	GetTransferNotes: function(pkTransferId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetTransferNotes", token, server, "pkTransferId=" + pkTransferId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetTransferProperties
	GetTransferProperties: function(pkTransferId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetTransferProperties", token, server, "pkTransferId=" + pkTransferId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetTransferWithItems
	GetTransferWithItems: function(pkTransferId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetTransferWithItems", token, server, "pkTransferId=" + pkTransferId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-GetTransferWithNotes
	GetTransferWithNotes: function(pkTransferId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/GetTransferWithNotes", token, server, "pkTransferId=" + pkTransferId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-IsDraftTransferChanged
	IsDraftTransferChanged: function(pkTransferId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/IsDraftTransferChanged", token, server, "pkTransferId=" + pkTransferId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-PrintTransfer
	PrintTransfer: function(pkTransferId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/PrintTransfer", token, server, "pkTransferId=" + pkTransferId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-RemoveAllEmptyBins
	RemoveAllEmptyBins: function(token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/RemoveAllEmptyBins", token, server, "");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-RemoveItemFromTransfer
	RemoveItemFromTransfer: function(pkTransferId,pkTransferItemId,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/RemoveItemFromTransfer", token, server, "pkTransferId=" + pkTransferId + "&pkTransferItemId=" + pkTransferItemId +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-SearchTransfersAllLocations
	SearchTransfersAllLocations: function(searchType,searchText,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/SearchTransfersAllLocations", token, server, "searchType=" + searchType + "&searchText=" + searchText +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-SearchTransfersByLocation
	SearchTransfersByLocation: function(searchType,searchText,locationID,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/SearchTransfersByLocation", token, server, "searchType=" + searchType + "&searchText=" + searchText + "&locationID=" + locationID +"");
	},
	// http://apidoc.linnworks.net/#/WarehouseTransfer-SetReferenceNumber
	SetReferenceNumber: function(pkTransferId,ReferenceNumber,token, server)
	{
		return Factory.GetResponse("WarehouseTransfer/SetReferenceNumber", token, server, "pkTransferId=" + pkTransferId + "&ReferenceNumber=" + ReferenceNumber +"");
	},
};
