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
	public class RefundInfo
	{ 
		public Guid? pkRefundRowId;
		public String SKU;
		public String ItemTitle;
		public Boolean IsItem;
		public Boolean IsService;
		public Double Amount;
		public String Reason;
		public Boolean Actioned;
		public DateTime? ActionDate;
		public String ReturnReference;
		public Double? Cost;
		public PostSaleStatusType RefundStatus;
		public Boolean IgnoredValidation;
		public Guid? fkOrderItemRowId;
		public Boolean ShouldSerializeChannelReason;
		public String ChannelReason;
		public Boolean ShouldSerializeChannelReasonSec;
		public String ChannelReasonSec;
		public Boolean IsNew;
	} 
}