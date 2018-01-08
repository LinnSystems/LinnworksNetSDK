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
	public class Column
	{ 
		public ColumnNameType ColumnName;
		public String DisplayName;
		public GroupType Group;
		public FieldType Field;
		public SortDirectionType SortDirection;
		public Double Width;
		public Boolean IsEditable;
	} 
}