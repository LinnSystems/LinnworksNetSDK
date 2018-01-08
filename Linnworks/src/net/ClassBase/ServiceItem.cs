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
	public class ServiceItem
	{ 
		public Guid pkOrderItemRowId;
		public String ServiceName;
		public Double ServiceCost;
		public ChannelRefundReason DefaultChannelReason;
		public ChannelRefundSubReason DefaultChannelSubReason;
		public String ItemNumber;
		public Boolean AllowsAutomatedRefund;
	} 
}