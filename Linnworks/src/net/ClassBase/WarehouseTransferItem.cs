using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{ 
	public class WarehouseTransferItem
	{ 
		public Guid PkTransferItemId;
		public Guid FkStockItemId;
		public String SKU;
		public String Barcode;
		public String ItemTitle;
		public Int32 RequestedQuantity;
		public Int32 SentQuantity;
		public Int32? ReceivedQuantity;
		public Int32 InFromLocationQuantity;
		public Int32 DueFromLocationQuantity;
		public Int32 InToLocationQuantity;
		public Int32 ItemNoteCount;
		public String BinRackNumber;
		public Guid PkBinId;
		public List<WarehouseTransferItemNote> ItemNotes;
	} 
}