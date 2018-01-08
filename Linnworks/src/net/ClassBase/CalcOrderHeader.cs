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
	public class CalcOrderHeader
	{ 
		public Guid pkOrderID;
		public Int32 nOrderId;
		public Guid fkPostalServiceId;
		public Guid fkCountryId;
		public String cCountry;
		public Double ItemWeight;
		public Guid fkPackagingGroupId;
		public Guid fkPackagingTypeId;
		public Boolean IsSplitPackaging;
		public Double PackagingWeight;
		public Double TotalWeight;
		public Decimal? TotalWidth;
		public Decimal? TotalHeight;
		public Decimal? TotalDepth;
		public Boolean ManualAdjust;
		public Boolean CanAutoSplit;
		public Boolean IsAutoSplit;
		public Int32 SplitPackageCount;
		public Boolean LabelPrinted;
		public List<String> CalculationHints;
		public List<CalcOrderItem> Items;
		public List<CalcBin> Bins;
		public PackingResult ThreeDimPackaging;
		public CalcMethod DimMethod;
		public SqlDataRecord DataRecordMetaData;
	} 
}