using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class WarehouseTransferController : BaseController, IWarehouseTransferController
    {
        public WarehouseTransferController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Use this call to add multiple items to the transfer (only works for transfers in draft/request states) 
        /// </summary>
        /// <param name="request">Request object with data needed</param>
        public AddItemsToTransferResponse AddItemsToTransfer(AddItemsToTransferRequest request)
		{
			var response = GetResponse("WarehouseTransfer/AddItemsToTransfer", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AddItemsToTransferResponse>(response);
		}

		/// <summary>
        /// Use this call to add an item to the transfer (only works for transfers in draft/request states) 
        /// </summary>
        /// <param name="fkTransferId">fkTransferId</param>
        /// <param name="pkStockItemId">pkStockItemId</param>
        /// <returns>A WarehouseTransferItem object</returns>
        public WarehouseTransferItem AddItemToTransfer(Guid fkTransferId,Guid pkStockItemId)
		{
			var response = GetResponse("WarehouseTransfer/AddItemToTransfer", "fkTransferId=" + fkTransferId + "&pkStockItemId=" + pkStockItemId + "");
            return JsonFormatter.ConvertFromJson<WarehouseTransferItem>(response);
		}

		/// <summary>
        /// Use this call to add a note to a bin 
        /// </summary>
        /// <param name="fkTransferBinId">fkTransferBinId</param>
        /// <param name="note">Note text</param>
        /// <param name="fkTransferId">fkTransferId</param>
        /// <returns>ID of note</returns>
        public Guid AddTransferBinNote(Guid fkTransferBinId,String note,Guid fkTransferId)
		{
			var response = GetResponse("WarehouseTransfer/AddTransferBinNote", "fkTransferBinId=" + fkTransferBinId + "&note=" + System.Net.WebUtility.UrlEncode(note) + "&fkTransferId=" + fkTransferId + "");
            return JsonFormatter.ConvertFromJson<Guid>(response);
		}

		/// <summary>
        /// Use this call to add a note to a transfer item. 
        /// </summary>
        /// <param name="fkTransferId">The id of the transfer to which the item belongs.</param>
        /// <param name="fkTransferItemId">The id of the item.</param>
        /// <param name="note">The note text.</param>
        /// <returns>The id of the new note.</returns>
        public Guid AddTransferItemNote(Guid fkTransferId,Guid fkTransferItemId,String note)
		{
			var response = GetResponse("WarehouseTransfer/AddTransferItemNote", "fkTransferId=" + fkTransferId + "&fkTransferItemId=" + fkTransferItemId + "&note=" + System.Net.WebUtility.UrlEncode(note) + "");
            return JsonFormatter.ConvertFromJson<Guid>(response);
		}

		/// <summary>
        /// Use this call to add a note to the transfer 
        /// </summary>
        /// <param name="pkTransferId">pkTransferId</param>
        /// <param name="note">Note text</param>
        /// <returns>ID of note</returns>
        public Guid AddTransferNote(Guid pkTransferId,String note)
		{
			var response = GetResponse("WarehouseTransfer/AddTransferNote", "pkTransferId=" + pkTransferId + "&note=" + System.Net.WebUtility.UrlEncode(note) + "");
            return JsonFormatter.ConvertFromJson<Guid>(response);
		}

		/// <summary>
        /// Use this call to add a property to the transfer. 
        /// </summary>
        /// <param name="fkTransferId">The transfer to add the property to.</param>
        /// <param name="propertyName">The property name.</param>
        /// <param name="propertyValue">The property value.</param>
        /// <returns>Returns the id of the property.</returns>
        public Guid AddTransferProperty(Guid fkTransferId,String propertyName,String propertyValue)
		{
			var response = GetResponse("WarehouseTransfer/AddTransferProperty", "fkTransferId=" + fkTransferId + "&propertyName=" + System.Net.WebUtility.UrlEncode(propertyName) + "&propertyValue=" + System.Net.WebUtility.UrlEncode(propertyValue) + "");
            return JsonFormatter.ConvertFromJson<Guid>(response);
		}

		/// <summary>
        /// Use this call to allocate stock, in part or in full, from one bin to another. 
        /// </summary>
        /// <param name="pkSrcBinId">The id of the source bin.</param>
        /// <param name="pkDstBinId">The id of the destination bin.</param>
        /// <param name="pkTransferItemId">The transfer item to be reallocated.</param>
        /// <param name="quantity">The quantity to reallocate.</param>
        /// <returns>Returns the actual quantity reallocated (if the source bin has less than requested than the number returned will reflect the smaller quantity).</returns>
        public Int32 AllocateItemToBin(Guid pkSrcBinId,Guid pkDstBinId,Guid pkTransferItemId,Int32 quantity)
		{
			var response = GetResponse("WarehouseTransfer/AllocateItemToBin", "pkSrcBinId=" + pkSrcBinId + "&pkDstBinId=" + pkDstBinId + "&pkTransferItemId=" + pkTransferItemId + "&quantity=" + quantity + "");
            return JsonFormatter.ConvertFromJson<Int32>(response);
		}

		/// <summary>
        /// Use this call to change details of a bin. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer the bin belongs to.</param>
        /// <param name="pkBinId">The id of the bin.</param>
        /// <param name="BinName">The new name for the bin (pass an empty string if no change is required).</param>
        /// <param name="BinReference">The new reference for the bin (pass an empty string if no change is required).</param>
        /// <param name="BinBarcode">The new barcode for the bin  (pass an empty string if no change is required).</param>
        public void ChangeBinDetails(Guid pkTransferId,Guid pkBinId,String BinName,String BinReference,String BinBarcode)
		{
			GetResponse("WarehouseTransfer/ChangeBinDetails", "pkTransferId=" + pkTransferId + "&pkBinId=" + pkBinId + "&BinName=" + System.Net.WebUtility.UrlEncode(BinName) + "&BinReference=" + System.Net.WebUtility.UrlEncode(BinReference) + "&BinBarcode=" + System.Net.WebUtility.UrlEncode(BinBarcode) + "");
		}

		/// <summary>
        /// Use this call to update the from location of a transfer. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer.</param>
        /// <param name="newLocationId">The location id which represents the from location.</param>
        public void ChangeTransferFromLocation(Guid pkTransferId,Guid newLocationId)
		{
			GetResponse("WarehouseTransfer/ChangeTransferFromLocation", "pkTransferId=" + pkTransferId + "&newLocationId=" + newLocationId + "");
		}

		/// <summary>
        /// Use this call to change the received quantity of a transfer item. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer.</param>
        /// <param name="pkBinId">The id of the bin.</param>
        /// <param name="pkTransferItemId">The id of the bin item.</param>
        /// <param name="Quantity">The new quantity.</param>
        public void ChangeTransferItemReceivedQuantity(Guid pkTransferId,Guid pkBinId,Guid pkTransferItemId,Int32? Quantity)
		{
			GetResponse("WarehouseTransfer/ChangeTransferItemReceivedQuantity", "pkTransferId=" + pkTransferId + "&pkBinId=" + pkBinId + "&pkTransferItemId=" + pkTransferItemId + "&Quantity=" + Quantity + "");
		}

		/// <summary>
        /// Use this call to change the requested quantity for an item on a transfer in Draft or Request states. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer.</param>
        /// <param name="pkTransferItemId">The id of the transfer item.</param>
        /// <param name="Quantity">The new request quantity.</param>
        public void ChangeTransferItemRequestQuantity(Guid pkTransferId,Guid pkTransferItemId,Int32 Quantity)
		{
			GetResponse("WarehouseTransfer/ChangeTransferItemRequestQuantity", "pkTransferId=" + pkTransferId + "&pkTransferItemId=" + pkTransferItemId + "&Quantity=" + Quantity + "");
		}

		/// <summary>
        /// Use this call to change the sent quantity of an item in the specified bin. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer.</param>
        /// <param name="pkBinId">The id of the bin.</param>
        /// <param name="pkTransferItemId">The id of the item.</param>
        /// <param name="Quantity">The new quantity.</param>
        /// <returns>The revised bin item.</returns>
        public WarehouseTransferItem ChangeTransferItemSentQuantity(Guid pkTransferId,Guid pkBinId,Guid pkTransferItemId,Int32 Quantity)
		{
			var response = GetResponse("WarehouseTransfer/ChangeTransferItemSentQuantity", "pkTransferId=" + pkTransferId + "&pkBinId=" + pkBinId + "&pkTransferItemId=" + pkTransferItemId + "&Quantity=" + Quantity + "");
            return JsonFormatter.ConvertFromJson<WarehouseTransferItem>(response);
		}

		/// <summary>
        /// Use this call to update the from and to locations of a transfer. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer.</param>
        /// <param name="fromLocationId">The location id which represents the from location.</param>
        /// <param name="toLocationId">The location id which represents the to location.</param>
        public void ChangeTransferLocations(Guid pkTransferId,Guid fromLocationId,Guid toLocationId)
		{
			GetResponse("WarehouseTransfer/ChangeTransferLocations", "pkTransferId=" + pkTransferId + "&fromLocationId=" + fromLocationId + "&toLocationId=" + toLocationId + "");
		}

		/// <summary>
        /// Use this call to change a property belonging to a given transfer. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer the property belongs to.</param>
        /// <param name="pkTransferPropertyId">The id of the property.</param>
        /// <param name="newValue">The new value for the property.</param>
        public void ChangeTransferProperty(Guid pkTransferId,Guid pkTransferPropertyId,String newValue)
		{
			GetResponse("WarehouseTransfer/ChangeTransferProperty", "pkTransferId=" + pkTransferId + "&pkTransferPropertyId=" + pkTransferPropertyId + "&newValue=" + System.Net.WebUtility.UrlEncode(newValue) + "");
		}

		/// <summary>
        /// Use this call to change a transfer's status 
        /// </summary>
        /// <param name="pkTransferId">pkTransferId for transfer requiring status change</param>
        /// <param name="newStatus">new status for transfer</param>
        public void ChangeTransferStatus(Guid pkTransferId,TransferStatus newStatus)
		{
			GetResponse("WarehouseTransfer/ChangeTransferStatus", "pkTransferId=" + pkTransferId + "&newStatus=" + newStatus.ToString() + "");
		}

		/// <summary>
        /// Use this call to update the to location of a transfer. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer.</param>
        /// <param name="newLocationId">The location id which represents the to location.</param>
        public void ChangeTransferToLocation(Guid pkTransferId,Guid newLocationId)
		{
			GetResponse("WarehouseTransfer/ChangeTransferToLocation", "pkTransferId=" + pkTransferId + "&newLocationId=" + newLocationId + "");
		}

		/// <summary>
        /// Use this call to see if a draft transfer already exists for the two locations 
        /// </summary>
        /// <param name="toLocationId">The id of the location the transfer should be going to</param>
        /// <param name="fromLocationId">The id of the location the transfer should be coming from</param>
        /// <returns>Returns an empty guid if no transfer is found. Otherwise, returns the id of the transfer.</returns>
        public Guid CheckForDraftTransfer(Guid toLocationId,Guid fromLocationId)
		{
			var response = GetResponse("WarehouseTransfer/CheckForDraftTransfer", "toLocationId=" + toLocationId + "&fromLocationId=" + fromLocationId + "");
            return JsonFormatter.ConvertFromJson<Guid>(response);
		}

		/// <summary>
        /// Use this call to create a new bin. 
        /// </summary>
        /// <param name="pkTransferId">The transfer to create the bin for.</param>
        /// <param name="barcode">The barcode of the bin.</param>
        /// <returns>Returns an instance of WarehouseTransferBin representing the newly created bin.</returns>
        public WarehouseTransferBin CreateNewBin(Guid pkTransferId,String barcode)
		{
			var response = GetResponse("WarehouseTransfer/CreateNewBin", "pkTransferId=" + pkTransferId + "&barcode=" + System.Net.WebUtility.UrlEncode(barcode) + "");
            return JsonFormatter.ConvertFromJson<WarehouseTransferBin>(response);
		}

		/// <summary>
        /// Use this call to create a new transfer request from discrepancies 
        /// </summary>
        /// <param name="pkTransferId">pkTransferId</param>
        /// <returns>New transfer</returns>
        public WarehouseTransfer CreateTransferFromDescrepancies(Guid pkTransferId)
		{
			var response = GetResponse("WarehouseTransfer/CreateTransferFromDescrepancies", "pkTransferId=" + pkTransferId + "");
            return JsonFormatter.ConvertFromJson<WarehouseTransfer>(response);
		}

		/// <summary>
        /// Use this call to create a new transfer request with default reference number 
        /// </summary>
        /// <param name="fromLocationId">pkLocationId for from Location</param>
        /// <param name="toLocationId">pkLocationId for to Location</param>
        /// <returns>New transfer</returns>
        public WarehouseTransfer CreateTransferRequestWithReturn(Guid fromLocationId,Guid toLocationId)
		{
			var response = GetResponse("WarehouseTransfer/CreateTransferRequestWithReturn", "fromLocationId=" + fromLocationId + "&toLocationId=" + toLocationId + "");
            return JsonFormatter.ConvertFromJson<WarehouseTransfer>(response);
		}

		/// <summary>
        /// Use this call to delete a draft transfer with no items, properties or notes. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer to be deleted.</param>
        public void DeleteEmptyDraftTransfer(Guid pkTransferId)
		{
			GetResponse("WarehouseTransfer/DeleteEmptyDraftTransfer", "pkTransferId=" + pkTransferId + "");
		}

		/// <summary>
        /// Use this call to delete a transfer 
        /// </summary>
        /// <param name="pkTransferId">pkTransferId</param>
        /// <param name="DeleteReason">Explanation for deletion</param>
        public void DeleteTransfer(Guid pkTransferId,String DeleteReason)
		{
			GetResponse("WarehouseTransfer/DeleteTransfer", "pkTransferId=" + pkTransferId + "&DeleteReason=" + System.Net.WebUtility.UrlEncode(DeleteReason) + "");
		}

		/// <summary>
        /// Use this call to delete a property from the transfer 
        /// </summary>
        /// <param name="pkTransferId">pkTransferId</param>
        /// <param name="pkTransferPropertyId">pkTransferPropertyId</param>
        public void DeleteTransferProperty(Guid pkTransferId,Guid pkTransferPropertyId)
		{
			GetResponse("WarehouseTransfer/DeleteTransferProperty", "pkTransferId=" + pkTransferId + "&pkTransferPropertyId=" + pkTransferPropertyId + "");
		}

		/// <summary>
        /// Use this call to get all active transfers for all locations 
        /// </summary>
        /// <returns>List of active transfers for all locations</returns>
        public List<WarehouseTransfer> GetActiveTransfersAllLocations()
		{
			var response = GetResponse("WarehouseTransfer/GetActiveTransfersAllLocations", "");
            return JsonFormatter.ConvertFromJson<List<WarehouseTransfer>>(response);
		}

		/// <summary>
        /// Use this call to get all of the active transfers related to this location 
        /// </summary>
        /// <param name="locationId">pkLocationId for</param>
        /// <returns>List of active transfers relating to particular location</returns>
        public List<WarehouseTransfer> GetActiveTransfersForLocation(Guid locationId)
		{
			var response = GetResponse("WarehouseTransfer/GetActiveTransfersForLocation", "locationId=" + locationId + "");
            return JsonFormatter.ConvertFromJson<List<WarehouseTransfer>>(response);
		}

		/// <summary>
        /// Use this call to retrieve all of the archived transfers in the system (i.e. Delivered or Deleted). 
        /// </summary>
        /// <param name="pageNumber">The page number (starting at 1).</param>
        /// <param name="entriesPerPage">The number of entries to be returned per page.</param>
        /// <returns>A paged result containing the relevant transfers.</returns>
        public GenericPagedResult<WarehouseTransfer> GetArchivedTransfers(Int32 pageNumber,Int32 entriesPerPage)
		{
			var response = GetResponse("WarehouseTransfer/GetArchivedTransfers", "pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<WarehouseTransfer>>(response);
		}

		/// <summary>
        /// Use this call to search for archived transfers which were archived between two dates. 
        /// </summary>
        /// <param name="start">The start date.</param>
        /// <param name="end">The end date.</param>
        /// <param name="pageNumber">The page number (starting at 1).</param>
        /// <param name="entriesPerPage">The number of entries to be returned per page.</param>
        /// <returns>A paged result containing the relevant transfers.</returns>
        public GenericPagedResult<WarehouseTransfer> GetArchivedTransfersBetweenArchivedDates(DateTime start,DateTime end,Int32 pageNumber,Int32 entriesPerPage)
		{
			var response = GetResponse("WarehouseTransfer/GetArchivedTransfersBetweenArchivedDates", "start=" + System.Net.WebUtility.UrlEncode(start.ToString("yyyy-MM-dd HH:mm:ss")) + "&end=" + System.Net.WebUtility.UrlEncode(end.ToString("yyyy-MM-dd HH:mm:ss")) + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<WarehouseTransfer>>(response);
		}

		/// <summary>
        /// Use this call to search for archived transfers which were created between two dates. 
        /// </summary>
        /// <param name="start">The start date.</param>
        /// <param name="end">The end date.</param>
        /// <param name="pageNumber">The page number (starting at 1).</param>
        /// <param name="entriesPerPage">The number of entries to be returned per page.</param>
        /// <returns>A paged result containing the relevant transfers.</returns>
        public GenericPagedResult<WarehouseTransfer> GetArchivedTransfersBetweenDates(DateTime start,DateTime end,Int32 pageNumber,Int32 entriesPerPage)
		{
			var response = GetResponse("WarehouseTransfer/GetArchivedTransfersBetweenDates", "start=" + System.Net.WebUtility.UrlEncode(start.ToString("yyyy-MM-dd HH:mm:ss")) + "&end=" + System.Net.WebUtility.UrlEncode(end.ToString("yyyy-MM-dd HH:mm:ss")) + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<WarehouseTransfer>>(response);
		}

		/// <summary>
        /// Use this call to search for archived transfers which match a specific search term. 
        /// </summary>
        /// <param name="searchType">The type of search.</param>
        /// <param name="filter">The search term.</param>
        /// <param name="pageNumber">The page number (starting at 1).</param>
        /// <param name="entriesPerPage">The number of entries to be returned per page.</param>
        /// <returns>A paged result containing the relevant transfers.</returns>
        public GenericPagedResult<WarehouseTransfer> GetArchivedTransfersFiltered(SearchType searchType,String filter,Int32 pageNumber,Int32 entriesPerPage)
		{
			var response = GetResponse("WarehouseTransfer/GetArchivedTransfersFiltered", "searchType=" + searchType.ToString() + "&filter=" + System.Net.WebUtility.UrlEncode(filter) + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<WarehouseTransfer>>(response);
		}

		/// <summary>
        /// Use this call to get a list of items whose quantities do not match those that were originally expected. E.g. Received < Sent when Delivered or Sent < Requested when Accepted. Only call this method once after the transfer is Accepted and once when it has been Delivered. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer.</param>
        /// <returns>A list of transfer items and relevant quantities.</returns>
        public List<WarehouseTransferItem> GetDiscrepancyItems(Guid pkTransferId)
		{
			var response = GetResponse("WarehouseTransfer/GetDiscrepancyItems", "pkTransferId=" + pkTransferId + "");
            return JsonFormatter.ConvertFromJson<List<WarehouseTransferItem>>(response);
		}

		/// <summary>
        /// Use this call to load a list of basic transfers 
        /// </summary>
        /// <param name="ids">The Ids to load</param>
        /// <returns>A list of transfers with basic details loaded</returns>
        public List<WarehouseTransfer> GetListTransfers(List<Guid> ids)
		{
			var response = GetResponse("WarehouseTransfer/GetListTransfers", "ids=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(ids)) + "");
            return JsonFormatter.ConvertFromJson<List<WarehouseTransfer>>(response);
		}

		/// <summary>
        /// Use this call to retrieve a basic list of transfers which have been significantly modified between the specified UTC date and now. 
        /// </summary>
        /// <param name="updateDate">A UTC date/time</param>
        /// <returns>A list of transfers with basic information loaded.</returns>
        public List<WarehouseTransfer> GetModifiedBasic(DateTime updateDate)
		{
			var response = GetResponse("WarehouseTransfer/GetModifiedBasic", "updateDate=" + System.Net.WebUtility.UrlEncode(updateDate.ToString("yyyy-MM-dd HH:mm:ss")) + "");
            return JsonFormatter.ConvertFromJson<List<WarehouseTransfer>>(response);
		}

		/// <summary>
        /// Use this call to get the current UTC date 
        /// </summary>
        /// <returns>Returns the current UTC date/time</returns>
        public DateTime GetServerTime()
		{
			var response = GetResponse("WarehouseTransfer/GetServerTime", "");
            return JsonFormatter.ConvertFromJson<DateTime>(response);
		}

		/// <summary>
        /// Use this call to retrieve information on inbound transfers and purchase orders for the given transfer item. 
        /// </summary>
        /// <param name="pkTransferItemId">The transfer item id.</param>
        /// <returns>Returns a list of inbound stock.</returns>
        public List<StockAvailability> GetStockAvailability(Guid pkTransferItemId)
		{
			var response = GetResponse("WarehouseTransfer/GetStockAvailability", "pkTransferItemId=" + pkTransferItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockAvailability>>(response);
		}

		/// <summary>
        /// Use this call to retrieve all of the audit entries for the specified transfer. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer to retrieve audit entries for.</param>
        /// <returns>A list of transfer audit entries.</returns>
        public List<WarehouseTransferAudit> GetTransferAudit(Guid pkTransferId)
		{
			var response = GetResponse("WarehouseTransfer/GetTransferAudit", "pkTransferId=" + pkTransferId + "");
            return JsonFormatter.ConvertFromJson<List<WarehouseTransferAudit>>(response);
		}

		/// <summary>
        /// Use this call to retrieve notes from a specific bin. 
        /// </summary>
        /// <param name="pkBinId">The id of the bin.</param>
        /// <returns>A list of notes associated with the bin.</returns>
        public List<WarehouseTransferBinNote> GetTransferBinNotes(Guid pkBinId)
		{
			var response = GetResponse("WarehouseTransfer/GetTransferBinNotes", "pkBinId=" + pkBinId + "");
            return JsonFormatter.ConvertFromJson<List<WarehouseTransferBinNote>>(response);
		}

		/// <summary>
        /// Use this call to retrieve the notes from a transfer item. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer to which the item belongs.</param>
        /// <param name="pkTransferItemId">The id of the transfer item.</param>
        /// <returns>A list of notes associated with the item.</returns>
        public List<WarehouseTransferItemNote> GetTransferItemNotes(Guid pkTransferId,Guid pkTransferItemId)
		{
			var response = GetResponse("WarehouseTransfer/GetTransferItemNotes", "pkTransferId=" + pkTransferId + "&pkTransferItemId=" + pkTransferItemId + "");
            return JsonFormatter.ConvertFromJson<List<WarehouseTransferItemNote>>(response);
		}

		/// <summary>
        /// Use this call to retrieve a list of items on  the order and request/sent/received levels. This method will return multiple entries for a single item if the item exists in multiple bins. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer.</param>
        /// <returns>A list of transfer items.</returns>
        public List<WarehouseTransferItem> GetTransferItems(Guid pkTransferId)
		{
			var response = GetResponse("WarehouseTransfer/GetTransferItems", "pkTransferId=" + pkTransferId + "");
            return JsonFormatter.ConvertFromJson<List<WarehouseTransferItem>>(response);
		}

		/// <summary>
        /// Use this call to retrieve a list of transfer-level notes for a given transfer. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer</param>
        /// <returns>A list of notes for the transfer.</returns>
        public List<WarehouseTransferNote> GetTransferNotes(Guid pkTransferId)
		{
			var response = GetResponse("WarehouseTransfer/GetTransferNotes", "pkTransferId=" + pkTransferId + "");
            return JsonFormatter.ConvertFromJson<List<WarehouseTransferNote>>(response);
		}

		/// <summary>
        /// Use this call to retrieve a list of properties associated with a given transfer. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer.</param>
        /// <returns>A list of properties.</returns>
        public List<WarehouseTransferProperty> GetTransferProperties(Guid pkTransferId)
		{
			var response = GetResponse("WarehouseTransfer/GetTransferProperties", "pkTransferId=" + pkTransferId + "");
            return JsonFormatter.ConvertFromJson<List<WarehouseTransferProperty>>(response);
		}

		/// <summary>
        /// Use this call to get a transfer object with its items. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer to be loaded.</param>
        /// <returns>The transfer object complete with items.</returns>
        public WarehouseTransfer GetTransferWithItems(Guid pkTransferId)
		{
			var response = GetResponse("WarehouseTransfer/GetTransferWithItems", "pkTransferId=" + pkTransferId + "");
            return JsonFormatter.ConvertFromJson<WarehouseTransfer>(response);
		}

		/// <summary>
        /// Use this call to get a warehouse transfer object with items 
        /// </summary>
        /// <param name="pkTransferId">pkTransferId for required Transfer</param>
        /// <returns>Warehouse Transfer Object with items</returns>
        public WarehouseTransfer GetTransferWithNotes(Guid pkTransferId)
		{
			var response = GetResponse("WarehouseTransfer/GetTransferWithNotes", "pkTransferId=" + pkTransferId + "");
            return JsonFormatter.ConvertFromJson<WarehouseTransfer>(response);
		}

		/// <summary>
        /// Use this call to work out if a draft transfer has been changed since it was created. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer to check.</param>
        /// <returns>A boolean indicating whether or not the transfer has changed (True = Changed, False = Unchanged).</returns>
        public Boolean IsDraftTransferChanged(Guid pkTransferId)
		{
			var response = GetResponse("WarehouseTransfer/IsDraftTransferChanged", "pkTransferId=" + pkTransferId + "");
            return JsonFormatter.ConvertFromJson<Boolean>(response);
		}

		/// <summary>
        /// Creates a PDF for this transfer and returns the URL 
        /// </summary>
        /// <param name="pkTransferId">The transfer ID</param>
        /// <returns>URL of PDF with auto-print flag</returns>
        public String PrintTransfer(Guid pkTransferId)
		{
			var response = GetResponse("WarehouseTransfer/PrintTransfer", "pkTransferId=" + pkTransferId + "");
            return JsonFormatter.ConvertFromJson<String>(response);
		}

		/// <summary>
        /// Use this call to delete bins with no items. To be used if a bin is created and no items are assigned to it. 
        /// </summary>
        public void RemoveAllEmptyBins()
		{
			GetResponse("WarehouseTransfer/RemoveAllEmptyBins", "");
		}

		/// <summary>
        /// Use this call to remove an item from a transfer. 
        /// </summary>
        /// <param name="pkTransferId">The id of the transfer.</param>
        /// <param name="pkTransferItemId">The id of the transfer item.</param>
        public void RemoveItemFromTransfer(Guid pkTransferId,Guid pkTransferItemId)
		{
			GetResponse("WarehouseTransfer/RemoveItemFromTransfer", "pkTransferId=" + pkTransferId + "&pkTransferItemId=" + pkTransferItemId + "");
		}

		/// <summary>
        /// Use this call to search for transfers which match a specific criteria 
        /// </summary>
        /// <param name="searchType">The type of search.</param>
        /// <param name="searchText">The search term.</param>
        /// <returns>A list of the relevant transfer ids.</returns>
        public List<Guid> SearchTransfersAllLocations(SearchType searchType,String searchText)
		{
			var response = GetResponse("WarehouseTransfer/SearchTransfersAllLocations", "searchType=" + searchType.ToString() + "&searchText=" + System.Net.WebUtility.UrlEncode(searchText) + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Use this call to search for transfers which match a specific criteria 
        /// </summary>
        /// <param name="searchType">The type of search.</param>
        /// <param name="searchText">The search term.</param>
        /// <param name="locationID">The location ID to search.</param>
        /// <returns>A list of the relevant transfer ids.</returns>
        public List<Guid> SearchTransfersByLocation(SearchType searchType,String searchText,Guid locationID)
		{
			var response = GetResponse("WarehouseTransfer/SearchTransfersByLocation", "searchType=" + searchType.ToString() + "&searchText=" + System.Net.WebUtility.UrlEncode(searchText) + "&locationID=" + locationID + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Use this call to change the transfer reference number (this call only works before the transfer is in transit) 
        /// </summary>
        /// <param name="pkTransferId">The transfer id of the transfer to change the reference number of.</param>
        /// <param name="ReferenceNumber">The new reference number.</param>
        public void SetReferenceNumber(Guid pkTransferId,String ReferenceNumber)
		{
			GetResponse("WarehouseTransfer/SetReferenceNumber", "pkTransferId=" + pkTransferId + "&ReferenceNumber=" + System.Net.WebUtility.UrlEncode(ReferenceNumber) + "");
		} 
    }
}