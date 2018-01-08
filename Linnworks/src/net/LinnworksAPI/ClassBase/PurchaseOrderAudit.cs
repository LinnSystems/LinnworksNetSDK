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
	public class PurchaseOrderAudit
	{ 
		public Guid pkPurchaseAuditTrailId;
		public DateTime AuditTrailDateTimeStamp;
		public Guid fkPurchaseId;
		public String AuditTrailType;
		public String AuditTrailTag;
		public String AuditTrailNote;
		public String UserName;
		public String AuditTrailDate;
		public String AuditTrailTime;
	} 
}