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
	public class UpdateGroupRequest
	{ 
		public Int32 GroupId;
		public String Name;
		public Int32? MaxOrderCount;
		public GroupCondition Condition;
		public GroupAction Action;
	} 
}