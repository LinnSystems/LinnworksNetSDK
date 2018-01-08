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
	public class SetOrderPackagingRequest
	{ 
		public Guid fkPackagingGroupId;
		public Guid fkPackagingTypeId;
		public Guid pkOrderId;
		public Double TotalWeight;
		public Boolean ManualAdjust;
		public Boolean IsAutoSplit;
		public Decimal TotalDepth;
		public Decimal TotalHeight;
		public Decimal TotalWidth;
	} 
}