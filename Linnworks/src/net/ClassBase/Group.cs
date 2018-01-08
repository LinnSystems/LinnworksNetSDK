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
	public class Group
	{ 
		public Int32 GroupId;
		public Guid LocationId;
		public String Name;
		public String Prefix;
		public Int32 Seed;
		public Int32 MaxOrderCount;
		public Int32 Prevalence;
		public Int32 JobCount;
		public Int32 OrderCount;
		public Int32 AttachmentCount;
		public GroupCondition Condition;
		public GroupAction Action;
		public Boolean HasAction;
	} 
}