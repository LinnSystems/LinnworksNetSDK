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
	public class JobError
	{ 
		public Int32 JobErrorId;
		public String Action;
		public Guid? OrderId;
		public Int32 ErrorType;
		public String ErrorText;
	} 
}