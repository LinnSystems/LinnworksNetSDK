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
	public class AuditEntry
	{ 
		public Int32 sid_history;
		public Guid fkOrderId;
		public String HistoryNote;
		public String fkOrderHistoryTypeId;
		public DateTime DateStamp;
		public String Tag;
		public String UpdatedBy;
		public String TypeDescription;
	} 
}