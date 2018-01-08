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
	public class RefundItem
	{ 
		public Guid? pkRefundRowId;
		public Boolean IsManualRefund;
		public RefundItemType Type;
		public Guid? fkOrderItemId;
		public Int32 RefundQty;
		public Double RefundAmount;
		public String Reason;
		public String ChannelReason;
		public String ChannelReasonSec;
	} 
}