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
	public class UpdateStatus
	{ 
		public Boolean Notes;
		public Boolean Items;
		public Boolean Properties;
		public Boolean Information;
		public Boolean Status;
	} 
}