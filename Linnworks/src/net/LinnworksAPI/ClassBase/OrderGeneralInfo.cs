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
	public class OrderGeneralInfo
	{ 
		public Int32 Status;
		public Boolean LabelPrinted;
		public String LabelError;
		public Boolean InvoicePrinted;
		public Boolean PickListPrinted;
		public Boolean IsRuleRun;
		public Int32 Notes;
		public Boolean PartShipped;
		public Byte? Marker;
		public String ReferenceNum;
		public String SecondaryReference;
		public String ExternalReferenceNum;
		public DateTime ReceivedDate;
		public String Source;
		public String SubSource;
		public String SiteCode;
		public Boolean HoldOrCancel;
		public DateTime DespatchByDate;
		public Guid Location;
		public Int32 NumItems;
		public IRulesEngineHelper RulesEngine;
	} 
}