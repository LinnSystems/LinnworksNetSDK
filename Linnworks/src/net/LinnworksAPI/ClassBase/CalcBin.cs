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
	public class CalcBin
	{ 
		public Guid pkBinId;
		public String TrackingNumber;
		public String LabelId;
		public Decimal? Weight;
		public DateTime? PrintDate;
		public Decimal? Cost;
		public Guid fkPackagingTypeId;
		public Decimal? Width;
		public Decimal? Height;
		public Decimal? Depth;
		public Decimal? PackagingWeight;
		public Decimal? ItemWeight;
		public Boolean ManualAdjust;
		public List<CalcBinItem> Items;
		public SqlDataRecord DataRecordMetaData;
	} 
}