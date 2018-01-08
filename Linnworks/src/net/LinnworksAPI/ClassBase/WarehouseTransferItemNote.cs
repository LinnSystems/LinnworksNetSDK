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
	public class WarehouseTransferItemNote
	{ 
		public Guid PkTransferItemNoteId;
		public String NoteUser;
		public String Note;
		public DateTime NoteDateTime;
		public Boolean NoteRead;
		public Guid FkBinId;
		public Guid PkTransferItemId;
	} 
}